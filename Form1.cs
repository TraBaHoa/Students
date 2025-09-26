namespace BaiTap4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtStudentID = new TextBox();
            txtFullName = new TextBox();
            optMale = new RadioButton();
            optFemale = new RadioButton();
            txtAverageScore = new TextBox();
            cmbFaculty = new ComboBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvStudent = new DataGridView();
            lblTotalMale = new Label();
            txtTotalMale = new TextBox();
            lblTotalFemale = new Label();
            txtTotalFemale = new TextBox();
            this.DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Blue;
            lblTitle.Location = new Point(208, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(300, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Quản Lý Thông Tin Sinh Viên";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 1;
            label2.Text = "Thông Tin Sinh Viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 91);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 2;
            label3.Text = "Mã Sinh Viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 130);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 4;
            label4.Text = "Họ Tên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 177);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 6;
            label5.Text = "Giới Tính";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 218);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 9;
            label6.Text = "Điểm TB";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 259);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 11;
            label7.Text = "Khoa";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(134, 84);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(139, 23);
            txtStudentID.TabIndex = 3;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(134, 127);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(186, 23);
            txtFullName.TabIndex = 5;
            // 
            // optMale
            // 
            optMale.AutoSize = true;
            optMale.Location = new Point(134, 173);
            optMale.Name = "optMale";
            optMale.Size = new Size(51, 19);
            optMale.TabIndex = 7;
            optMale.Text = "Nam";
            // 
            // optFemale
            // 
            optFemale.AutoSize = true;
            optFemale.Checked = true;
            optFemale.Location = new Point(208, 173);
            optFemale.Name = "optFemale";
            optFemale.Size = new Size(41, 19);
            optFemale.TabIndex = 8;
            optFemale.TabStop = true;
            optFemale.Text = "Nữ";
            // 
            // txtAverageScore
            // 
            txtAverageScore.Location = new Point(134, 211);
            txtAverageScore.Name = "txtAverageScore";
            txtAverageScore.Size = new Size(121, 23);
            txtAverageScore.TabIndex = 10;
            // 
            // cmbFaculty
            // 
            cmbFaculty.Items.AddRange(new object[] { "QTKD", "CNTT", "NNA" });
            cmbFaculty.Location = new Point(134, 251);
            cmbFaculty.Name = "cmbFaculty";
            cmbFaculty.Size = new Size(186, 23);
            cmbFaculty.TabIndex = 12;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(134, 324);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 28);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Thêm/Sửa";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(255, 324);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 28);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Xoá";
            // 
            // dgvStudent
            // 
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Columns.AddRange(new DataGridViewColumn[] { this.DataGridViewTextBoxColumn, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dgvStudent.Location = new Point(354, 84);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudent.Size = new Size(438, 217);
            dgvStudent.TabIndex = 15;
            dgvStudent.CellContentClick += dgvStudent_CellContentClick;
            // 
            // lblTotalMale
            // 
            lblTotalMale.AutoSize = true;
            lblTotalMale.Location = new Point(538, 330);
            lblTotalMale.Name = "lblTotalMale";
            lblTotalMale.Size = new Size(79, 15);
            lblTotalMale.TabIndex = 16;
            lblTotalMale.Text = "Tổng SV Nam";
            // 
            // txtTotalMale
            // 
            txtTotalMale.Location = new Point(632, 324);
            txtTotalMale.Name = "txtTotalMale";
            txtTotalMale.ReadOnly = true;
            txtTotalMale.Size = new Size(40, 23);
            txtTotalMale.TabIndex = 17;
            // 
            // lblTotalFemale
            // 
            lblTotalFemale.AutoSize = true;
            lblTotalFemale.Location = new Point(678, 326);
            lblTotalFemale.Name = "lblTotalFemale";
            lblTotalFemale.Size = new Size(23, 15);
            lblTotalFemale.TabIndex = 18;
            lblTotalFemale.Text = "Nữ";
            // 
            // txtTotalFemale
            // 
            txtTotalFemale.Location = new Point(713, 323);
            txtTotalFemale.Name = "txtTotalFemale";
            txtTotalFemale.ReadOnly = true;
            txtTotalFemale.Size = new Size(40, 23);
            txtTotalFemale.TabIndex = 19;
            // 
            // DataGridViewTextBoxColumn
            // 
            this.DataGridViewTextBoxColumn.HeaderText = "MSSV";
            this.DataGridViewTextBoxColumn.Name = "DataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Họ Tên";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Giới Tính";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Điểm TB";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Khoa";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Form1
            // 
            ClientSize = new Size(804, 389);
            Controls.Add(lblTitle);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(txtStudentID);
            Controls.Add(label4);
            Controls.Add(txtFullName);
            Controls.Add(label5);
            Controls.Add(optMale);
            Controls.Add(optFemale);
            Controls.Add(label6);
            Controls.Add(txtAverageScore);
            Controls.Add(label7);
            Controls.Add(cmbFaculty);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(dgvStudent);
            Controls.Add(lblTotalMale);
            Controls.Add(txtTotalMale);
            Controls.Add(lblTotalFemale);
            Controls.Add(txtTotalFemale);
            Name = "Form1";
            Text = "Quản Lý Sinh Viên";
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbFaculty.Items.AddRange(new string[] { "QTKD", "CNTT", "NNA" });
            cmbFaculty.SelectedIndex = 0;

            optFemale.Checked = true;

            dgvStudent.ColumnCount = 5;
            dgvStudent.Columns[0].Name = "MSSV";
            dgvStudent.Columns[1].Name = "Họ Tên";
            dgvStudent.Columns[2].Name = "Giới Tính";
            dgvStudent.Columns[3].Name = "ĐTB";
            dgvStudent.Columns[4].Name = "Khoa";

            dgvStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            lblTotalMale.Text = "0";
            txtTotalFemale.Text = "0";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
