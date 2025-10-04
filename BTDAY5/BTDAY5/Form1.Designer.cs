namespace BTDAY5
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tscmbFont = new System.Windows.Forms.ToolStripComboBox();
            this.tscmbSize = new System.Windows.Forms.ToolStripComboBox();
            this.tsbBold = new System.Windows.Forms.ToolStripButton();
            this.tsbItalic = new System.Windows.Forms.ToolStripButton();
            this.tsbUnderline = new System.Windows.Forms.ToolStripButton();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.stsMain = new System.Windows.Forms.StatusStrip();
            this.tsslblWordCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.stsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong,
            this.mnuFormat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.mnuFileOpen,
            this.mnuFileSave,
            this.mnuFileExit});
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(88, 24);
            this.mnuHeThong.Text = "Hệ Thống";
            this.mnuHeThong.Click += new System.EventHandler(this.mnuHeThong_Click);
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.Image = ((System.Drawing.Image)(resources.GetObject("mnuFileNew.Image")));
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.Size = new System.Drawing.Size(235, 26);
            this.mnuFileNew.Text = "Tạo Văn Bản";
            this.mnuFileNew.Click += new System.EventHandler(this.mnuFileNew_Click);
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Image = ((System.Drawing.Image)(resources.GetObject("mnuFileOpen.Image")));
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.Size = new System.Drawing.Size(235, 26);
            this.mnuFileOpen.Text = "Mở Tập Tin";
            this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Image = ((System.Drawing.Image)(resources.GetObject("mnuFileSave.Image")));
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.Size = new System.Drawing.Size(235, 26);
            this.mnuFileSave.Text = "Lưu nội dung văn bản";
            this.mnuFileSave.Click += new System.EventHandler(this.mnuFileSave_Click);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(235, 26);
            this.mnuFileExit.Text = "Thoát";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuFormat
            // 
            this.mnuFormat.Name = "mnuFormat";
            this.mnuFormat.Size = new System.Drawing.Size(94, 24);
            this.mnuFormat.Text = "Định Dạng";
            this.mnuFormat.Click += new System.EventHandler(this.mnuFormat_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbSave,
            this.tscmbFont,
            this.tscmbSize,
            this.tsbBold,
            this.tsbItalic,
            this.tsbUnderline});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 28);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNew
            // 
            this.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(29, 25);
            this.tsbNew.Text = "toolStripButton1";
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(29, 25);
            this.tsbSave.Text = "toolStripButton2";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tscmbFont
            // 
            this.tscmbFont.Name = "tscmbFont";
            this.tscmbFont.Size = new System.Drawing.Size(121, 28);
            this.tscmbFont.SelectedIndexChanged += new System.EventHandler(this.tscmbFont_SelectedIndexChanged);
            this.tscmbFont.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tscmbFont_KeyUp);
            this.tscmbFont.Click += new System.EventHandler(this.tscmbFont_Click);
            // 
            // tscmbSize
            // 
            this.tscmbSize.Name = "tscmbSize";
            this.tscmbSize.Size = new System.Drawing.Size(121, 28);
            this.tscmbSize.SelectedIndexChanged += new System.EventHandler(this.tscmbSize_SelectedIndexChanged);
            this.tscmbSize.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tscmbSize_KeyUp);
            this.tscmbSize.Click += new System.EventHandler(this.tscmbSize_Click);
            // 
            // tsbBold
            // 
            this.tsbBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBold.Image = ((System.Drawing.Image)(resources.GetObject("tsbBold.Image")));
            this.tsbBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBold.Name = "tsbBold";
            this.tsbBold.Size = new System.Drawing.Size(29, 25);
            this.tsbBold.Text = "toolStripButton3";
            this.tsbBold.Click += new System.EventHandler(this.tsbBold_Click);
            // 
            // tsbItalic
            // 
            this.tsbItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbItalic.Image = ((System.Drawing.Image)(resources.GetObject("tsbItalic.Image")));
            this.tsbItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbItalic.Name = "tsbItalic";
            this.tsbItalic.Size = new System.Drawing.Size(29, 25);
            this.tsbItalic.Text = "toolStripButton4";
            this.tsbItalic.Click += new System.EventHandler(this.tsbItalic_Click);
            // 
            // tsbUnderline
            // 
            this.tsbUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUnderline.Image = ((System.Drawing.Image)(resources.GetObject("tsbUnderline.Image")));
            this.tsbUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUnderline.Name = "tsbUnderline";
            this.tsbUnderline.Size = new System.Drawing.Size(29, 25);
            this.tsbUnderline.Text = "toolStripButton5";
            this.tsbUnderline.Click += new System.EventHandler(this.tsbUnderline_Click);
            // 
            // rtbContent
            // 
            this.rtbContent.Location = new System.Drawing.Point(0, 67);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(800, 385);
            this.rtbContent.TabIndex = 3;
            this.rtbContent.Text = "";
            this.rtbContent.TextChanged += new System.EventHandler(this.rtbContent_TextChanged);
            // 
            // stsMain
            // 
            this.stsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblWordCount});
            this.stsMain.Location = new System.Drawing.Point(0, 424);
            this.stsMain.Name = "stsMain";
            this.stsMain.Size = new System.Drawing.Size(800, 26);
            this.stsMain.TabIndex = 4;
            this.stsMain.Text = "statusStrip1";
            // 
            // tsslblWordCount
            // 
            this.tsslblWordCount.Name = "tsslblWordCount";
            this.tsslblWordCount.Size = new System.Drawing.Size(151, 20);
            this.tsslblWordCount.Text = "toolStripStatusLabel1";
            this.tsslblWordCount.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.tsslblWordCount.Click += new System.EventHandler(this.tsslblWordCount_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stsMain);
            this.Controls.Add(this.rtbContent);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.stsMain.ResumeLayout(false);
            this.stsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuFormat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripComboBox tscmbFont;
        private System.Windows.Forms.ToolStripComboBox tscmbSize;
        private System.Windows.Forms.ToolStripButton tsbBold;
        private System.Windows.Forms.ToolStripButton tsbItalic;
        private System.Windows.Forms.ToolStripButton tsbUnderline;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.StatusStrip stsMain;
        private System.Windows.Forms.ToolStripStatusLabel tsslblWordCount;
    }
}

