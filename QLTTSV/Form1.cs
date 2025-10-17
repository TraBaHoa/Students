using QLTTSV.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTTSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StudentContextDB db = new StudentContextDB();
            List<Faculty> ListKhoa = db.Faculties.ToList();
            List<Student> ListStudent = db.Students.ToList();
            cbbKhoa.DataSource = ListKhoa;
            cbbKhoa.DisplayMember = "FacultyName";
            cbbKhoa.ValueMember = "FacultyID";
            BindGrid(ListStudent);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                StudentContextDB context = new StudentContextDB();
                List<Student> students = context.Students.ToList();

                var student = students.FirstOrDefault(s => s.StudentID == txtMSSV.Text);
                if (student != null)
                {
                    if (students.Any(s => s.StudentID == txtMSSV.Text && s.StudentID != student.StudentID))
                    {
                        MessageBox.Show("Mã SV đã tồn tại. Vui lòng nhập một mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    student.FullName = txtHoTen.Text;
                    student.AverageScore = double.Parse(txtDTB.Text);
                    student.FacultyID = int.Parse(cbbKhoa.SelectedValue.ToString());

                    // Save changes to the database
                    context.SaveChanges();

                    // Reload the data
                    BindGrid(context.Students.ToList());
                    MessageBox.Show("Chỉnh sửa thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sinh viên không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                txtMSSV.Text = selectedRow.Cells[0].Value.ToString();
                txtHoTen.Text = selectedRow.Cells[1].Value.ToString();
                cbbKhoa.Text = selectedRow.Cells[2].Value.ToString();
                txtDTB.Text = selectedRow.Cells[3].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                StudentContextDB context = new StudentContextDB();
                List<Student> students = context.Students.ToList();

                var student = students.FirstOrDefault(s => s.StudentID == txtMSSV.Text);
                if (student != null)
                {
                    var result = MessageBox.Show($"Bạn có chắc chắn muốn xóa sinh viên {student.FullName} không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        context.Students.Remove(student);
                        context.SaveChanges();

                        // Reload the data
                        BindGrid(context.Students.ToList());
                        MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Sinh viên không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearForm()
        {
            txtMSSV.Clear();
            txtHoTen.Clear();
            txtDTB.Clear();
            cbbKhoa.SelectedItem = "";
            txtMSSV.Focus();
        }



        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void frmStudentManagement_Load(object sender, EventArgs e)
        {
            try
            {
                StudentContextDB context = new StudentContextDB();
                List<Faculty> listFalcultys = context.Faculties.ToList(); //lấy các khoa
                List<Student> listStudent = context.Students.ToList(); //lấy sinh viên
                FillFalcultyCombobox(listFalcultys);
                BindGrid(listStudent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillFalcultyCombobox(List<Faculty> listFalcultys)
        {
            this.cbbKhoa.DataSource = listFalcultys;
            this.cbbKhoa.DisplayMember = "FacultyName";
            this.cbbKhoa.ValueMember = "FacultyID";
        }

        private void BindGrid(List<Student> listStudent)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in listStudent)
            {            
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = item.StudentID;
                dataGridView1.Rows[index].Cells[1].Value = item.FullName;
                dataGridView1.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                dataGridView1.Rows[index].Cells[3].Value = item.AverageScore;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                StudentContextDB context = new StudentContextDB();
                List<Student> studentLst = context.Students.ToList();
                if (studentLst.Any(s => s.StudentID == txtMSSV.Text))
                {
                    MessageBox.Show("Mã SV đã tồn tại. Vui lòng nhập một mã khác.", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                var newStudent = new Student
                {
                    StudentID = txtMSSV.Text,
                    FullName = txtHoTen.Text,
                    AverageScore = double.Parse(txtDTB.Text),
                    FacultyID = int.Parse(cbbKhoa.SelectedValue.ToString()),

                };
                context.Students.Add(newStudent);
                context.SaveChanges();
                BindGrid(context.Students.ToList());
                MessageBox.Show("Thêm sinh viên thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm dữ liệu: {ex.Message}", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
