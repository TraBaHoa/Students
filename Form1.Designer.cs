namespace Lab05_GUI
{
    partial class Form1
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
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbCN = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.txtHTen = new System.Windows.Forms.TextBox();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ptbADD = new System.Windows.Forms.PictureBox();
            this.btnTS = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ckbChuaDKCN = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKýChuyênNgànhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThemAnh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbADD)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvSinhVien.Location = new System.Drawing.Point(412, 142);
            this.dgvSinhVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.Size = new System.Drawing.Size(639, 343);
            this.dgvSinhVien.TabIndex = 0;
            this.dgvSinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "MSSV";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ và Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Khoa";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ĐTB";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Chuyên Ngành";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // cbbCN
            // 
            this.cbbCN.FormattingEnabled = true;
            this.cbbCN.Location = new System.Drawing.Point(127, 119);
            this.cbbCN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbCN.Name = "cbbCN";
            this.cbbCN.Size = new System.Drawing.Size(160, 24);
            this.cbbCN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "MSSV";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(127, 37);
            this.txtMSSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(160, 22);
            this.txtMSSV.TabIndex = 3;
            // 
            // txtHTen
            // 
            this.txtHTen.Location = new System.Drawing.Point(127, 80);
            this.txtHTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHTen.Name = "txtHTen";
            this.txtHTen.Size = new System.Drawing.Size(160, 22);
            this.txtHTen.TabIndex = 3;
            // 
            // txtDTB
            // 
            this.txtDTB.Location = new System.Drawing.Point(127, 169);
            this.txtDTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.Size = new System.Drawing.Size(132, 22);
            this.txtDTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ và Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chuyên Ngành";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "ĐTB";
            // 
            // ptbADD
            // 
            this.ptbADD.Location = new System.Drawing.Point(127, 217);
            this.ptbADD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ptbADD.Name = "ptbADD";
            this.ptbADD.Size = new System.Drawing.Size(133, 86);
            this.ptbADD.TabIndex = 4;
            this.ptbADD.TabStop = false;
            // 
            // btnTS
            // 
            this.btnTS.Location = new System.Drawing.Point(37, 331);
            this.btnTS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTS.Name = "btnTS";
            this.btnTS.Size = new System.Drawing.Size(100, 28);
            this.btnTS.TabIndex = 5;
            this.btnTS.Text = "Thêm/Sửa";
            this.btnTS.UseVisualStyleBackColor = true;
            this.btnTS.Click += new System.EventHandler(this.btnTS_Click);
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(188, 331);
            this.btnX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(100, 28);
            this.btnX.TabIndex = 5;
            this.btnX.Text = "Xoá";
            this.btnX.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ảnh Đại Diện";
            // 
            // ckbChuaDKCN
            // 
            this.ckbChuaDKCN.AutoSize = true;
            this.ckbChuaDKCN.Location = new System.Drawing.Point(837, 113);
            this.ckbChuaDKCN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbChuaDKCN.Name = "ckbChuaDKCN";
            this.ckbChuaDKCN.Size = new System.Drawing.Size(192, 20);
            this.ckbChuaDKCN.TabIndex = 6;
            this.ckbChuaDKCN.Text = "SV Chưa ĐK Chuyên Ngành";
            this.ckbChuaDKCN.UseVisualStyleBackColor = true;
            this.ckbChuaDKCN.CheckedChanged += new System.EventHandler(this.ckbChuaDKCN_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(216, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(509, 42);
            this.label6.TabIndex = 7;
            this.label6.Text = "Quản Lý Thông Tin Sinh Viên";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngKýChuyênNgànhToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.chứcNăngToolStripMenuItem.Text = "Chức Năng";
            // 
            // đăngKýChuyênNgànhToolStripMenuItem
            // 
            this.đăngKýChuyênNgànhToolStripMenuItem.Name = "đăngKýChuyênNgànhToolStripMenuItem";
            this.đăngKýChuyênNgànhToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.đăngKýChuyênNgànhToolStripMenuItem.Text = "Đăng Ký Chuyên Ngành";
            this.đăngKýChuyênNgànhToolStripMenuItem.Click += new System.EventHandler(this.đăngKýChuyênNgànhToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThemAnh);
            this.groupBox1.Controls.Add(this.btnX);
            this.groupBox1.Controls.Add(this.btnTS);
            this.groupBox1.Controls.Add(this.ptbADD);
            this.groupBox1.Controls.Add(this.txtDTB);
            this.groupBox1.Controls.Add(this.txtHTen);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMSSV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbCN);
            this.groupBox1.Location = new System.Drawing.Point(19, 105);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(385, 380);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // btnThemAnh
            // 
            this.btnThemAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemAnh.Location = new System.Drawing.Point(281, 234);
            this.btnThemAnh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemAnh.Name = "btnThemAnh";
            this.btnThemAnh.Size = new System.Drawing.Size(96, 42);
            this.btnThemAnh.TabIndex = 5;
            this.btnThemAnh.Text = "...";
            this.btnThemAnh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThemAnh.UseVisualStyleBackColor = true;
            this.btnThemAnh.Click += new System.EventHandler(this.btnThemAnh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ckbChuaDKCN);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbADD)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.ComboBox cbbCN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.TextBox txtHTen;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox ptbADD;
        private System.Windows.Forms.Button btnTS;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ckbChuaDKCN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngKýChuyênNgànhToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThemAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

