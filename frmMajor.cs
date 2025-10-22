using Lab05_BUS;
using Lab05_DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05_GUI
{
    public partial class frmMajor : Form
    {
        private readonly Lab05_BUS.Student studentService = new Lab05_BUS.Student();
        private readonly FacultyService facultyService = new FacultyService();
        private readonly MajorService majorService = new MajorService();
        public frmMajor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmMajor_Load(object sender, EventArgs e)
        {
            try
            {
                var listFacultys = facultyService.All;
                FillFalcultyCombobox(listFacultys);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FillFalcultyCombobox(List<Faculty> listFacultys)
        {
            this.cbbDKKhoa.DataSource = listFacultys;
            this.cbbDKKhoa.DisplayMember = "FacultyName";
            this.cbbDKKhoa.ValueMember = "FacultyID";
        }

        private void FillMajorCombobox(List<Major> listMajors)
        {
            this.cbbDKCNganh.DataSource = listMajors;
            this.cbbDKCNganh.DisplayMember = "Name";
            this.cbbDKCNganh.ValueMember = "MajorID";
        }

        private void cbbDKKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Faculty selectedFaculty = cbbDKKhoa.SelectedItem as Faculty;
            if (selectedFaculty != null)
            {
                var ListMajor = majorService.GetAllByFaculty(selectedFaculty.FacultyID);
                FillMajorCombobox(ListMajor);
                var listStudents = studentService.GetAllHasNoMajorID(selectedFaculty.FacultyID);
                BindGrid(listStudents);
            }
        }

        private void BindGrid(List<Lab05_DAL.Entities.Student> listStudents)
        {
            throw new NotImplementedException();
        }

        private void BindGrid(List<Lab05_BUS.Student> listStudent)
        {
            dgvDKCN.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgvDKCN.Rows.Add();
                dgvDKCN.Rows[index].Cells[1].Value = item.StudentID;
                dgvDKCN.Rows[index].Cells[2].Value = item.FullName;
                if (item.Faculty != null)
                    dgvDKCN.Rows[index].Cells[3].Value = item.MajorName;
                dgvDKCN.Rows[index].Cells[4].Value = item.AverageScore + "";
                if (item.Major != null)
                    dgvDKCN.Rows[index].Cells[5].Value = item.MajorName + "";
            }
        }

        private void cbbDKCNganh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy chuyên ngành được chọn
                var selectedMajor = cbbDKCNganh.SelectedItem as Major;
                if (selectedMajor == null)
                {
                    MessageBox.Show("Vui lòng chọn chuyên ngành!");
                    return;
                }

                // Duyệt qua các dòng được chọn trong DataGridView
                foreach (DataGridViewRow row in dgvDKCN.Rows)
                {
                    bool isChecked = Convert.ToBoolean(row.Cells["Chon"].Value);
                    if (isChecked)
                    {
                        string studentID = row.Cells["MSSV"].Value.ToString();
                        var student = studentService.FindByID(studentID);
                        if (student != null)
                        {
                            student.MajorID = selectedMajor.MajorID;
                            studentService.InsertUpdate(student);
                        }
                    }
                }

                // Load lại danh sách sinh viên chưa đăng ký
                Faculty selectedFaculty = cbbDKKhoa.SelectedItem as Faculty;
                if (selectedFaculty != null)
                {
                    var listStudents = studentService.GetAllHasNoMajorID(selectedFaculty.FacultyID);
                    BindGrid(listStudents);
                }

                MessageBox.Show("Đăng ký chuyên ngành thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đăng ký: " + ex.Message);
            }
        }
    }
}
