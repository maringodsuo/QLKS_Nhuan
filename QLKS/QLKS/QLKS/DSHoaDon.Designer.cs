namespace QLKS
{
    partial class DSHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSHoaDon));
            this.dtgvHoaDon = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuocTich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenPhong = new System.Windows.Forms.ComboBox();
            this.txtTenKhachHang = new System.Windows.Forms.ComboBox();
            this.dtpNgayThue = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayDi = new System.Windows.Forms.DateTimePicker();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtTienCoc = new System.Windows.Forms.TextBox();
            this.cbIDThue = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongTienThue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTienThanhToan = new System.Windows.Forms.TextBox();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTenNhanVien = new System.Windows.Forms.Label();
            this.txtTienDV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbIDDV = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btThongKe = new System.Windows.Forms.Button();
            this.dtpDen = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpTu = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDon)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvHoaDon
            // 
            this.dtgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn19,
            this.SDT,
            this.CMND,
            this.NgayThanhToan,
            this.QuocTich});
            this.dtgvHoaDon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvHoaDon.Location = new System.Drawing.Point(0, 412);
            this.dtgvHoaDon.Name = "dtgvHoaDon";
            this.dtgvHoaDon.RowTemplate.Height = 24;
            this.dtgvHoaDon.Size = new System.Drawing.Size(1311, 312);
            this.dtgvHoaDon.TabIndex = 13;
            this.dtgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHoaDon_CellClick);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn8.HeaderText = "ID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "TenKhachHang";
            this.dataGridViewTextBoxColumn9.HeaderText = "Tên Khách Hàng";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "IDThue";
            this.dataGridViewTextBoxColumn19.HeaderText = "ID Phiều thuê";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "IDDichVu";
            this.SDT.HeaderText = "ID dịch vụ";
            this.SDT.Name = "SDT";
            // 
            // CMND
            // 
            this.CMND.DataPropertyName = "TongTien";
            this.CMND.HeaderText = "Tổng tiền";
            this.CMND.Name = "CMND";
            // 
            // NgayThanhToan
            // 
            this.NgayThanhToan.DataPropertyName = "NgayThanhToan";
            this.NgayThanhToan.HeaderText = "Ngày Thanh Toán";
            this.NgayThanhToan.Name = "NgayThanhToan";
            // 
            // QuocTich
            // 
            this.QuocTich.DataPropertyName = "TenNhanVien";
            this.QuocTich.HeaderText = "Nhân Viên";
            this.QuocTich.Name = "QuocTich";
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.FormattingEnabled = true;
            this.txtTenPhong.Location = new System.Drawing.Point(178, 127);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(169, 24);
            this.txtTenPhong.TabIndex = 89;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenKhachHang.FormattingEnabled = true;
            this.txtTenKhachHang.Location = new System.Drawing.Point(178, 86);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(169, 24);
            this.txtTenKhachHang.TabIndex = 88;
            // 
            // dtpNgayThue
            // 
            this.dtpNgayThue.Location = new System.Drawing.Point(178, 169);
            this.dtpNgayThue.Name = "dtpNgayThue";
            this.dtpNgayThue.Size = new System.Drawing.Size(169, 22);
            this.dtpNgayThue.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(20, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 86;
            this.label1.Text = "Thông Tin Phiếu Thuê";
            // 
            // dtpNgayDi
            // 
            this.dtpNgayDi.Location = new System.Drawing.Point(178, 209);
            this.dtpNgayDi.Name = "dtpNgayDi";
            this.dtpNgayDi.Size = new System.Drawing.Size(169, 22);
            this.dtpNgayDi.TabIndex = 85;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(21, 93);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(115, 17);
            this.label29.TabIndex = 79;
            this.label29.Text = "Tên Khách Hàng";
            this.label29.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(382, 90);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(64, 17);
            this.label28.TabIndex = 82;
            this.label28.Text = "Tiền Cọc";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(21, 127);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(78, 17);
            this.label27.TabIndex = 80;
            this.label27.Text = "Tên Phòng";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(21, 209);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(58, 17);
            this.label26.TabIndex = 81;
            this.label26.Text = "Ngày Đi";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(21, 169);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 17);
            this.label20.TabIndex = 84;
            this.label20.Text = "Ngày Thuê";
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.Location = new System.Drawing.Point(539, 90);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.Size = new System.Drawing.Size(169, 22);
            this.txtTienCoc.TabIndex = 78;
            // 
            // cbIDThue
            // 
            this.cbIDThue.FormattingEnabled = true;
            this.cbIDThue.Location = new System.Drawing.Point(178, 9);
            this.cbIDThue.Name = "cbIDThue";
            this.cbIDThue.Size = new System.Drawing.Size(169, 24);
            this.cbIDThue.TabIndex = 91;
            this.cbIDThue.SelectedIndexChanged += new System.EventHandler(this.cbIDThue_SelectedIndexChanged);
            this.cbIDThue.TextChanged += new System.EventHandler(this.cbIDThue_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 90;
            this.label2.Text = "Mã Phiếu Thuê";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 93;
            this.label3.Text = "Tổng tiền";
            // 
            // txtTongTienThue
            // 
            this.txtTongTienThue.Location = new System.Drawing.Point(539, 141);
            this.txtTongTienThue.Name = "txtTongTienThue";
            this.txtTongTienThue.Size = new System.Drawing.Size(169, 22);
            this.txtTongTienThue.TabIndex = 92;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 95;
            this.label4.Text = "Tiền cần thanh toán";
            // 
            // txtTienThanhToan
            // 
            this.txtTienThanhToan.Location = new System.Drawing.Point(539, 185);
            this.txtTienThanhToan.Name = "txtTienThanhToan";
            this.txtTienThanhToan.Size = new System.Drawing.Size(169, 22);
            this.txtTienThanhToan.TabIndex = 94;
            // 
            // btThem
            // 
            this.btThem.Image = global::QLKS.Properties.Resources.add_1_icon;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(753, 29);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(131, 55);
            this.btThem.TabIndex = 97;
            this.btThem.Text = "Thêm";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.Image = global::QLKS.Properties.Resources.Button_Delete_icon;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(923, 29);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(131, 55);
            this.btXoa.TabIndex = 98;
            this.btXoa.Text = "Xoá";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1107, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 55);
            this.button1.TabIndex = 99;
            this.button1.Text = "In Hoá Đơn";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtTim);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.btThongKe);
            this.panel2.Controls.Add(this.dtpDen);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.dtpTu);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btThem);
            this.panel2.Controls.Add(this.btXoa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 251);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1311, 161);
            this.panel2.TabIndex = 100;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.lbTenNhanVien);
            this.panel1.Controls.Add(this.txtTienDV);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbIDDV);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(812, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 251);
            this.panel1.TabIndex = 101;
            // 
            // lbTenNhanVien
            // 
            this.lbTenNhanVien.AutoSize = true;
            this.lbTenNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbTenNhanVien.Location = new System.Drawing.Point(326, 9);
            this.lbTenNhanVien.Name = "lbTenNhanVien";
            this.lbTenNhanVien.Size = new System.Drawing.Size(119, 20);
            this.lbTenNhanVien.TabIndex = 99;
            this.lbTenNhanVien.Text = "Tên Nhân Viên";
            // 
            // txtTienDV
            // 
            this.txtTienDV.Location = new System.Drawing.Point(192, 179);
            this.txtTienDV.Name = "txtTienDV";
            this.txtTienDV.Size = new System.Drawing.Size(169, 22);
            this.txtTienDV.TabIndex = 114;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 115;
            this.label7.Text = "Tổng tiền";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbIDDV
            // 
            this.cbIDDV.FormattingEnabled = true;
            this.cbIDDV.Location = new System.Drawing.Point(202, 83);
            this.cbIDDV.Name = "cbIDDV";
            this.cbIDDV.Size = new System.Drawing.Size(169, 24);
            this.cbIDDV.TabIndex = 102;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 101;
            this.label5.Text = "Mã Phiếu Dịch Vụ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(44, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 20);
            this.label6.TabIndex = 97;
            this.label6.Text = "Thông Tin Phiếu Dịch Vụ";
            // 
            // btThongKe
            // 
            this.btThongKe.AutoSize = true;
            this.btThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btThongKe.Image")));
            this.btThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThongKe.Location = new System.Drawing.Point(317, 26);
            this.btThongKe.Name = "btThongKe";
            this.btThongKe.Size = new System.Drawing.Size(149, 54);
            this.btThongKe.TabIndex = 104;
            this.btThongKe.Text = "Thống Kê";
            this.btThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThongKe.UseVisualStyleBackColor = true;
            this.btThongKe.Click += new System.EventHandler(this.btThongKe_Click);
            // 
            // dtpDen
            // 
            this.dtpDen.Location = new System.Drawing.Point(95, 62);
            this.dtpDen.Name = "dtpDen";
            this.dtpDen.Size = new System.Drawing.Size(190, 22);
            this.dtpDen.TabIndex = 103;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 102;
            this.label8.Text = "Đến Ngày";
            // 
            // dtpTu
            // 
            this.dtpTu.Location = new System.Drawing.Point(95, 13);
            this.dtpTu.Name = "dtpTu";
            this.dtpTu.Size = new System.Drawing.Size(193, 22);
            this.dtpTu.TabIndex = 101;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 100;
            this.label9.Text = "Từ Ngày";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(585, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(352, 17);
            this.label10.TabIndex = 107;
            this.label10.Text = "Nhập bất cứ thứ gì liên quan đến đối tượng để tìm kiếm";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(110, 118);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(436, 22);
            this.txtTim.TabIndex = 105;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 17);
            this.label11.TabIndex = 106;
            this.label11.Text = "Tìm kiếm: ";
            // 
            // DSHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 724);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTienThanhToan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTongTienThue);
            this.Controls.Add(this.cbIDThue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenPhong);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.dtpNgayThue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNgayDi);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtTienCoc);
            this.Controls.Add(this.dtgvHoaDon);
            this.Name = "DSHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH SÁCH HOÁ ĐƠN";
            this.Load += new System.EventHandler(this.DSHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvHoaDon;
        private System.Windows.Forms.ComboBox txtTenPhong;
        private System.Windows.Forms.ComboBox txtTenKhachHang;
        private System.Windows.Forms.DateTimePicker dtpNgayThue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayDi;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtTienCoc;
        private System.Windows.Forms.ComboBox cbIDThue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongTienThue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTienThanhToan;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuocTich;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTenNhanVien;
        private System.Windows.Forms.TextBox txtTienDV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbIDDV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btThongKe;
        private System.Windows.Forms.DateTimePicker dtpDen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpTu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label11;
    }
}