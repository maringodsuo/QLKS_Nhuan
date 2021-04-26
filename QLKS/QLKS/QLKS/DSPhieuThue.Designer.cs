namespace QLKS
{
    partial class txtTenKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(txtTenKH));
            this.dtgvPhieuThueP = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuocTich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btThongKe = new System.Windows.Forms.Button();
            this.dtpDen = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTu = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayDi = new System.Windows.Forms.DateTimePicker();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.labelgc = new System.Windows.Forms.Label();
            this.txtTienCoc = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.dtpNgayThue = new System.Windows.Forms.DateTimePicker();
            this.txtTenKhachHang = new System.Windows.Forms.ComboBox();
            this.txtTenPhong = new System.Windows.Forms.ComboBox();
            this.txtTinhTrang = new System.Windows.Forms.ComboBox();
            this.txtNhanVien = new System.Windows.Forms.ComboBox();
            this.errChiTiet = new System.Windows.Forms.ErrorProvider(this.components);
            this.btDichvu = new System.Windows.Forms.Button();
            this.btThanhtoan = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.lbTenNhanVien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuThueP)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvPhieuThueP
            // 
            this.dtgvPhieuThueP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvPhieuThueP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPhieuThueP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.SDT,
            this.CMND,
            this.QuocTich});
            this.dtgvPhieuThueP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvPhieuThueP.Location = new System.Drawing.Point(0, 349);
            this.dtgvPhieuThueP.Name = "dtgvPhieuThueP";
            this.dtgvPhieuThueP.RowTemplate.Height = 24;
            this.dtgvPhieuThueP.Size = new System.Drawing.Size(1311, 375);
            this.dtgvPhieuThueP.TabIndex = 12;
            this.dtgvPhieuThueP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPhieuThueP_CellClick);
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
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "TenPhong";
            this.dataGridViewTextBoxColumn10.HeaderText = "Tên Phòng";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "NgayThue";
            this.dataGridViewTextBoxColumn18.HeaderText = "Ngày Thuê";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "NgayKetThuc";
            this.dataGridViewTextBoxColumn19.HeaderText = "Ngày Đi";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "TienCoc";
            this.SDT.HeaderText = "Tiền Cọc";
            this.SDT.Name = "SDT";
            // 
            // CMND
            // 
            this.CMND.DataPropertyName = "TinhTrang";
            this.CMND.HeaderText = "Tình Trạng";
            this.CMND.Name = "CMND";
            // 
            // QuocTich
            // 
            this.QuocTich.DataPropertyName = "TenNhanVien";
            this.QuocTich.HeaderText = "Nhân Viên";
            this.QuocTich.Name = "QuocTich";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.lbTenNhanVien);
            this.panel3.Controls.Add(this.btThongKe);
            this.panel3.Controls.Add(this.dtpDen);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dtpTu);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtTim);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1311, 131);
            this.panel3.TabIndex = 13;
            // 
            // btThongKe
            // 
            this.btThongKe.AutoSize = true;
            this.btThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btThongKe.Image")));
            this.btThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThongKe.Location = new System.Drawing.Point(753, 50);
            this.btThongKe.Name = "btThongKe";
            this.btThongKe.Size = new System.Drawing.Size(149, 54);
            this.btThongKe.TabIndex = 77;
            this.btThongKe.Text = "Thống Kê";
            this.btThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThongKe.UseVisualStyleBackColor = true;
            this.btThongKe.Click += new System.EventHandler(this.btThongKe_Click);
            // 
            // dtpDen
            // 
            this.dtpDen.Location = new System.Drawing.Point(511, 69);
            this.dtpDen.Name = "dtpDen";
            this.dtpDen.Size = new System.Drawing.Size(190, 22);
            this.dtpDen.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 75;
            this.label3.Text = "Đến Ngày";
            // 
            // dtpTu
            // 
            this.dtpTu.Location = new System.Drawing.Point(163, 69);
            this.dtpTu.Name = "dtpTu";
            this.dtpTu.Size = new System.Drawing.Size(193, 22);
            this.dtpTu.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 73;
            this.label2.Text = "Từ Ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(618, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(352, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nhập bất cứ thứ gì liên quan đến đối tượng để tìm kiếm";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(143, 20);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(436, 22);
            this.txtTim.TabIndex = 0;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tìm kiếm: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(48, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 69;
            this.label1.Text = "Thông Tin Khách Hàng";
            // 
            // dtpNgayDi
            // 
            this.dtpNgayDi.Location = new System.Drawing.Point(753, 167);
            this.dtpNgayDi.Name = "dtpNgayDi";
            this.dtpNgayDi.Size = new System.Drawing.Size(189, 22);
            this.dtpNgayDi.TabIndex = 68;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(153, 169);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(169, 22);
            this.txtID.TabIndex = 51;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(32, 211);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(115, 17);
            this.label29.TabIndex = 55;
            this.label29.Text = "Tên Khách Hàng";
            this.label29.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(679, 218);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(64, 17);
            this.label28.TabIndex = 58;
            this.label28.Text = "Tiền Cọc";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(360, 172);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(78, 17);
            this.label27.TabIndex = 56;
            this.label27.Text = "Tên Phòng";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(679, 169);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(58, 17);
            this.label26.TabIndex = 57;
            this.label26.Text = "Ngày Đi";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(360, 214);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 17);
            this.label20.TabIndex = 63;
            this.label20.Text = "Ngày Thuê";
            // 
            // labelgc
            // 
            this.labelgc.AutoSize = true;
            this.labelgc.Location = new System.Drawing.Point(975, 221);
            this.labelgc.Name = "labelgc";
            this.labelgc.Size = new System.Drawing.Size(74, 17);
            this.labelgc.TabIndex = 64;
            this.labelgc.Text = "Nhân Viên";
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.Location = new System.Drawing.Point(753, 218);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.Size = new System.Drawing.Size(189, 22);
            this.txtTienCoc.TabIndex = 53;
            this.txtTienCoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTienCoc_KeyPress);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(975, 166);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(78, 17);
            this.label35.TabIndex = 65;
            this.label35.Text = "Tình Trạng";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(112, 171);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(21, 17);
            this.label25.TabIndex = 59;
            this.label25.Text = "ID";
            this.label25.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpNgayThue
            // 
            this.dtpNgayThue.Location = new System.Drawing.Point(458, 214);
            this.dtpNgayThue.Name = "dtpNgayThue";
            this.dtpNgayThue.Size = new System.Drawing.Size(190, 22);
            this.dtpNgayThue.TabIndex = 72;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.FormattingEnabled = true;
            this.txtTenKhachHang.Location = new System.Drawing.Point(153, 204);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(169, 24);
            this.txtTenKhachHang.TabIndex = 75;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.FormattingEnabled = true;
            this.txtTenPhong.Location = new System.Drawing.Point(458, 169);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(190, 24);
            this.txtTenPhong.TabIndex = 76;
            this.txtTenPhong.SelectedIndexChanged += new System.EventHandler(this.txtTenPhong_SelectedIndexChanged);
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Enabled = false;
            this.txtTinhTrang.FormattingEnabled = true;
            this.txtTinhTrang.Items.AddRange(new object[] {
            "Đang Thuê",
            "Đã thanh toán"});
            this.txtTinhTrang.Location = new System.Drawing.Point(1080, 167);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(169, 24);
            this.txtTinhTrang.TabIndex = 77;
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Enabled = false;
            this.txtNhanVien.FormattingEnabled = true;
            this.txtNhanVien.Location = new System.Drawing.Point(1080, 215);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(169, 24);
            this.txtNhanVien.TabIndex = 78;
            // 
            // errChiTiet
            // 
            this.errChiTiet.ContainerControl = this;
            // 
            // btDichvu
            // 
            this.btDichvu.Image = ((System.Drawing.Image)(resources.GetObject("btDichvu.Image")));
            this.btDichvu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDichvu.Location = new System.Drawing.Point(831, 288);
            this.btDichvu.Name = "btDichvu";
            this.btDichvu.Size = new System.Drawing.Size(153, 55);
            this.btDichvu.TabIndex = 80;
            this.btDichvu.Text = "Thêm Dịch Vụ";
            this.btDichvu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDichvu.UseVisualStyleBackColor = true;
            this.btDichvu.Click += new System.EventHandler(this.btDichvu_Click);
            // 
            // btThanhtoan
            // 
            this.btThanhtoan.Image = global::QLKS.Properties.Resources.Pay_Per_Click_icon;
            this.btThanhtoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThanhtoan.Location = new System.Drawing.Point(1029, 288);
            this.btThanhtoan.Name = "btThanhtoan";
            this.btThanhtoan.Size = new System.Drawing.Size(141, 55);
            this.btThanhtoan.TabIndex = 79;
            this.btThanhtoan.Text = "Thanh Toán";
            this.btThanhtoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThanhtoan.UseVisualStyleBackColor = true;
            this.btThanhtoan.Click += new System.EventHandler(this.button1_Click);
            // 
            // btLuu
            // 
            this.btLuu.Image = global::QLKS.Properties.Resources.Save_icon;
            this.btLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLuu.Location = new System.Drawing.Point(672, 288);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(109, 55);
            this.btLuu.TabIndex = 74;
            this.btLuu.Text = "Lưu";
            this.btLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btXoa
            // 
            this.btXoa.Image = global::QLKS.Properties.Resources.Button_Delete_icon;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(511, 288);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(109, 55);
            this.btXoa.TabIndex = 73;
            this.btXoa.Text = "Xoá";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Image = global::QLKS.Properties.Resources.Files_Edit_file_icon;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(324, 288);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(109, 55);
            this.btSua.TabIndex = 71;
            this.btSua.Text = "Sửa";
            this.btSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Image = global::QLKS.Properties.Resources.add_1_icon;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(163, 288);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(109, 55);
            this.btThem.TabIndex = 70;
            this.btThem.Text = "Thêm";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // lbTenNhanVien
            // 
            this.lbTenNhanVien.AutoSize = true;
            this.lbTenNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbTenNhanVien.Location = new System.Drawing.Point(1104, 0);
            this.lbTenNhanVien.Name = "lbTenNhanVien";
            this.lbTenNhanVien.Size = new System.Drawing.Size(119, 20);
            this.lbTenNhanVien.TabIndex = 100;
            this.lbTenNhanVien.Text = "Tên Nhân Viên";
            // 
            // txtTenKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 724);
            this.Controls.Add(this.btDichvu);
            this.Controls.Add(this.btThanhtoan);
            this.Controls.Add(this.txtNhanVien);
            this.Controls.Add(this.txtTinhTrang);
            this.Controls.Add(this.txtTenPhong);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.dtpNgayThue);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNgayDi);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.labelgc);
            this.Controls.Add(this.txtTienCoc);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dtgvPhieuThueP);
            this.Name = "txtTenKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH SÁCH PHIẾU THUÊ PHÒNG";
            this.Load += new System.EventHandler(this.DSPhieuThue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuThueP)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errChiTiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvPhieuThueP;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayDi;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label labelgc;
        private System.Windows.Forms.TextBox txtTienCoc;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.DateTimePicker dtpNgayThue;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuocTich;
        private System.Windows.Forms.ComboBox txtTenKhachHang;
        private System.Windows.Forms.ComboBox txtTenPhong;
        private System.Windows.Forms.ComboBox txtTinhTrang;
        private System.Windows.Forms.ComboBox txtNhanVien;
        private System.Windows.Forms.ErrorProvider errChiTiet;
        private System.Windows.Forms.DateTimePicker dtpDen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btThongKe;
        private System.Windows.Forms.Button btThanhtoan;
        private System.Windows.Forms.Button btDichvu;
        private System.Windows.Forms.Label lbTenNhanVien;
    }
}