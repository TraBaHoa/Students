using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab05_BUS;
using System.IO;
using Lab05_DAL.Entities;
using System.Data.Entity.Core.Metadata.Edm;
namespace Lab05_GUI
{
    
    public partial class Form1 : Form
    {
        private readonly Lab05_BUS.Student StudentService = new Lab05_BUS.Student();
        private readonly FacultyService facultyService = new FacultyService();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                setGridViewStyle();
                var listFacultys = facultyService.All;
                var listStudents = StudentService.GetAll();
                FillFalcultyCombobox(listFacultys);
                BindGrid(listStudents);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        
        
        private void FillFalcultyCombobox(List<Faculty> listFacultys)
        {
            listFacultys.Insert(0, new Faculty());
            this.cbbCN.DataSource = listFacultys;
            this.cbbCN.DisplayMember = "FacultyName";
            this.cbbCN.ValueMember = "FacultyID";
        }


        private void BindGrid(List<Lab05_DAL.Entities.Student> listStudent)
        {
            dgvSinhVien.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgvSinhVien.Rows.Add();
                dgvSinhVien.Rows[index].Cells[0].Value = item.StudentID;
                dgvSinhVien.Rows[index].Cells[1].Value = item.FullName;
                if (item.Faculty != null)
                    dgvSinhVien.Rows[index].Cells[2].Value =
                    item.Faculty.FacultyName;
                dgvSinhVien.Rows[index].Cells[3].Value = item.AverageScore + "";
                if (item.MajorID != null)
                    dgvSinhVien.Rows[index].Cells[4].Value = item.Major.Name + "";
                LoadAvatar(item.StudentID);
            }
        }

        

        public void setGridViewStyle()
        {
            dgvSinhVien.BorderStyle = BorderStyle.None;
            dgvSinhVien.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvSinhVien.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSinhVien.BackgroundColor = Color.White;
            dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }



        private void btnTS_Click(object sender, EventArgs e)
        {
            try
            {
                var Student = StudentService.FindByID(txtMSSV.Text);  new Lab05_BUS.Student();
                Student.StudentID = txtMSSV.Text.Trim();
                Student.FullName = txtHTen.Text.Trim();
                Student.AverageScore = double.Parse(txtDTB.Text);
                Student.FacultyID = Convert.ToInt32(cbbCN.SelectedValue.ToString());

                if (!string.IsNullOrEmpty(avatarFilePath))
                {
                    string avatarFileName = SaveAvatar(avatarFilePath, txtMSSV.Text);
                    if (string.IsNullOrEmpty(avatarFileName))
                    {
                        Student.Avatar = avatarFileName;
                    }
                }
                StudentService.InsertUpdate(Student);

                BindGrid(StudentService.GetAll());

                avatarFilePath = string.Empty;
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"Error adding data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string avatarFilePath = string.Empty;
        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog OpenFileDialog = new OpenFileDialog())
            {
                OpenFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png) | *.jpg; *.jpeg; *.png";
                if(OpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    avatarFilePath = OpenFileDialog.FileName;
                    ptbADD.Image = Image.FromFile(avatarFilePath);
                }
            }
        }

        private void LoadAvatar(String studentID)
        {
            const string ImagesFolderName = "Images";
            string folderPath = Path.Combine(Application.StartupPath, ImagesFolderName);

            var student = StudentService.FindByID(studentID);
            if (student != null || string.IsNullOrEmpty(student.Avatar))
            {
                ptbADD.Image = null;
                return;
            }
            string avatarFilePath = Path.Combine(folderPath, student.Avatar);

            if (File.Exists(avatarFilePath))
            {
                try
                {
                    using (var avataImage = Image.FromFile(avatarFilePath))
                    {
                        ptbADD.Image = new Bitmap(avataImage);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading avatar: {ex.Message}\nStack Trace: {ex.StackTrace}");
                    ptbADD.Image = null;
                }
            }
            else
            {
                ptbADD.Image = null;
            }
        }

        private string SaveAvatar(string sourceFilePath, string studentID)
        {
            const string ImageFolderName = "Image";
            try
            {
                if(string.IsNullOrWhiteSpace(sourceFilePath)|| string.IsNullOrWhiteSpace(studentID))
                {
                    throw new ArgumentException("Source file path and student ID must not be null or empty.");
                }
                if (!File.Exists(sourceFilePath))
                {
                    throw new FileNotFoundException($"Source file not found: {sourceFilePath}");
                }
                string folderPath = Path.Combine(Application.StartupPath, ImageFolderName);
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                string fileExtension = Path.GetExtension(sourceFilePath);
                string targetFileName = $"{studentID}{fileExtension}";
                string targetFilePath = Path.Combine(folderPath, targetFileName);

                File.Copy(sourceFilePath, targetFilePath, overwrite: true);
                return targetFileName;
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"Error saving avatar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        private void ckbChuaDKCN_CheckedChanged(object sender, EventArgs e)
        {
            var listStudents = new List<Lab05_DAL.Entities.Student>();
            if (this.ckbChuaDKCN.Checked)
                listStudents = StudentService.GetAllHasNoMajor();
            else
                listStudents = StudentService.GetAll();
            BindGrid(listStudents);
        }

        private void đăngKýChuyênNgànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMajor frm = new frmMajor();
            frm.ShowDialog();
        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];

                // Lấy giá trị từng ô
                txtMSSV.Text = row.Cells[0].Value?.ToString();
                txtHTen.Text = row.Cells[1].Value?.ToString();
                cbbCN.Text = row.Cells[2].Value?.ToString();
                txtDTB.Text = row.Cells[3].Value?.ToString();

                // Load avatar tương ứng
                string studentID = txtMSSV.Text.Trim();
                LoadAvatar(studentID);
            }
        }
    }
}
