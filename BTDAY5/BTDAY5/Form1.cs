using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BTDAY5
{
    public partial class frmMain : Form
    {
        private string currentFilePath = string.Empty;

        public frmMain()
        {
            InitializeComponent();

          
            this.rtbContent.SelectionChanged += rtbContent_SelectionChanged;
            this.rtbContent.TextChanged += rtbContent_TextChanged;

           
            this.tscmbFont.SelectedIndexChanged += tscmbFont_SelectedIndexChanged;
            this.tscmbFont.KeyUp += tscmbFont_KeyUp;
            this.tscmbSize.SelectedIndexChanged += tscmbSize_SelectedIndexChanged;
            this.tscmbSize.KeyUp += tscmbSize_KeyUp;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = "Soạn thảo văn bản";

        
            tscmbFont.Text = "Tahoma";
            tscmbSize.Text = "14";
            rtbContent.Font = new Font("Tahoma", 14);

     
            foreach (FontFamily font in new InstalledFontCollection().Families)
            {
                tscmbFont.Items.Add(font.Name);
            }

         
            List<int> listSize = new List<int> { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (var s in listSize)
            {
                tscmbSize.Items.Add(s.ToString());
            }

            UpdateWordCount();
        }


        private void NewFile()
        {
            rtbContent.Clear();
            rtbContent.Font = new Font("Tahoma", 14);
            tscmbFont.Text = "Tahoma";
            tscmbSize.Text = "14";
            currentFilePath = string.Empty;
            UpdateWordCount();
        }

        private void SaveFile()
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                SaveFileDialog saveDlg = new SaveFileDialog();
                saveDlg.Filter = "Rich Text Format (*.rtf)|*.rtf";
                saveDlg.DefaultExt = "rtf";

                if (saveDlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        rtbContent.SaveFile(saveDlg.FileName, RichTextBoxStreamType.RichText);
                        currentFilePath = saveDlg.FileName;
                        MessageBox.Show("Lưu văn bản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi lưu tệp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                try
                {
                    rtbContent.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                    MessageBox.Show("Lưu văn bản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu tệp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       
        private void mnuFileNew_Click(object sender, EventArgs e) => NewFile();
        private void tsbNew_Click(object sender, EventArgs e) => NewFile();

        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Filter = "Rich Text Format (*.rtf)|*.rtf|Tệp văn bản (*.txt)|*.txt|Tất cả tệp (*.*)|*.*";

            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (openDlg.FileName.ToLower().EndsWith(".rtf"))
                    {
                        rtbContent.LoadFile(openDlg.FileName, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        rtbContent.LoadFile(openDlg.FileName, RichTextBoxStreamType.PlainText);
                    }
                    currentFilePath = openDlg.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi mở tệp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            UpdateWordCount();
        }

        private void mnuFileSave_Click(object sender, EventArgs e) => SaveFile();
        private void tsbSave_Click(object sender, EventArgs e) => SaveFile();

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void mnuFormat_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.Color = rtbContent.SelectionColor;
            fontDlg.Font = rtbContent.SelectionFont ?? rtbContent.Font;
            fontDlg.ShowColor = true;
            fontDlg.ShowApply = true;
            fontDlg.ShowEffects = true;
            fontDlg.ShowHelp = true;

            if (fontDlg.ShowDialog() != DialogResult.Cancel)
            {
                rtbContent.SelectionColor = fontDlg.Color;
                rtbContent.SelectionFont = fontDlg.Font;
            }
        }

        
        private void ApplyFontAndSize()
        {
            string fontName = tscmbFont.Text;
            float fontSize;

            if (!float.TryParse(tscmbSize.Text, out fontSize))
            {
                fontSize = (rtbContent.SelectionFont != null) ? rtbContent.SelectionFont.Size : 14;
            }

            try
            {
              
                FontStyle currentStyle = FontStyle.Regular;
                if (rtbContent.SelectionFont != null)
                {
                    currentStyle = rtbContent.SelectionFont.Style;
                }

                rtbContent.SelectionFont = new Font(fontName, fontSize, currentStyle);
            }
            catch (Exception)
            {
                
            }
        }

        
        private void tscmbFont_SelectedIndexChanged(object sender, EventArgs e) => ApplyFontAndSize();
        private void tscmbFont_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) ApplyFontAndSize();
        }

        private void tscmbSize_SelectedIndexChanged(object sender, EventArgs e) => ApplyFontAndSize();
        private void tscmbSize_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) ApplyFontAndSize();
        }

        private void ToggleFontStyle(FontStyle style, ToolStripButton button)
        {
            if (rtbContent.SelectionFont == null) return;

            Font currentFont = rtbContent.SelectionFont;

            if (currentFont.Style.HasFlag(style))
            {
                rtbContent.SelectionFont = new Font(currentFont, currentFont.Style & ~style);
                button.Checked = false;
            }
            else
            {
                rtbContent.SelectionFont = new Font(currentFont, currentFont.Style | style);
                button.Checked = true;
            }
        }

        private void tsbBold_Click(object sender, EventArgs e)
        {
            ToggleFontStyle(FontStyle.Bold, tsbBold);
        }

        private void tsbItalic_Click(object sender, EventArgs e)
        {
            ToggleFontStyle(FontStyle.Italic, tsbItalic);
        }

        private void tsbUnderline_Click(object sender, EventArgs e)
        {
            ToggleFontStyle(FontStyle.Underline, tsbUnderline);
        }


       
        private void UpdateWordCount()
        {
            string text = rtbContent.Text;
            var words = text.Split(new char[] { ' ', '\r', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = words.Length;

            tsslblWordCount.Text = "Tổng số từ: " + wordCount.ToString();
        }

        private void rtbContent_TextChanged(object sender, EventArgs e)
        {
            UpdateWordCount();
        }

        private void rtbContent_SelectionChanged(object sender, EventArgs e)
        {
            if (rtbContent.SelectionFont != null)
            {
             
                tscmbFont.Text = rtbContent.SelectionFont.Name;
                tscmbSize.Text = rtbContent.SelectionFont.Size.ToString();

      
                tsbBold.Checked = rtbContent.SelectionFont.Bold;
                tsbItalic.Checked = rtbContent.SelectionFont.Italic;
                tsbUnderline.Checked = rtbContent.SelectionFont.Underline;

               
                tsbBold.BackColor = tsbBold.Checked ? SystemColors.ControlLight : SystemColors.Control;
                tsbItalic.BackColor = tsbItalic.Checked ? SystemColors.ControlLight : SystemColors.Control;
                tsbUnderline.BackColor = tsbUnderline.Checked ? SystemColors.ControlLight : SystemColors.Control;
            }
        }

 
        private void mnuHeThong_Click(object sender, EventArgs e) { }
        private void tscmbFont_Click(object sender, EventArgs e) { }
        private void tscmbSize_Click(object sender, EventArgs e) { }
        private void tsslblWordCount_Click(object sender, EventArgs e) { }

    }
}