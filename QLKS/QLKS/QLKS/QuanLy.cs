using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    //public delegate void LoadForm();
    public partial class QuanLy : Form
    {
        //SqlConnection con;
        //SqlCommand cmd;
        //SqlDataAdapter dap;
        //DataSet ds;

        //LinQ
        CSDLDataContext db = new CSDLDataContext();
        
        
        
        bool ktra=false, sua=false, them=false;
        bool ktraTT = false, suaTT = false, themTT = false;
        bool ktraDV = false, suaDV = false, themDV = false;
        bool ktraKH = false, suaKH = false, themKH = false;
        bool ktraCD = false, suaCD = false, themCD = false;
        bool ktraNV = false, suaNV = false, themNV = false;
        bool ktraP = false, suaP = false, themP = false;
        public QuanLy()
        {
            
            InitializeComponent();
            RemoveTabpage();


        }
        //public LoadForm load;
        //public void LoadP()
        //{
        //    dtgvPhong.DataSource = db.LoadPhong();
        //}
        private void QuanLy_Load(object sender, EventArgs e)
        {
            
            //con = new SqlConnection();
            //con.ConnectionString = @"Data Source=Nhuan;Initial Catalog=QLKS;Integrated Security=True";
            //con.Open();
            //LoadLoaiPhong("select * from LoaiPhong");       
            lbTenNhanVien.Text = Cons.Cons.tenNhanVien;
            switch (Cons.Cons.role)
            {
                case (int)Cons.Role.TiepTan:
                    nhânSựToolStripMenuItem.Visible = false;
                    btXoa.Visible = false;
                    btSua.Visible = false;
                    btThem.Visible = false;
                    btLuu.Visible = false;
                    btXoaTT.Visible = false;
                    btSuaTT.Visible = false;
                    btThemTT.Visible = false;
                    btLuuTT.Visible = false;
                    btXoaP.Visible = false;
                    btSuaP.Visible = false;
                    btThemP.Visible = false;
                    btLuuP.Visible = false;
                    btXoaDV.Visible = false;
                    btSuaDV.Visible = false;
                    btThemDV.Visible = false;
                    btLuuDV.Visible = false;
                    break;
                case (int)Cons.Role.KeToan:
                    MessageBox.Show("Ke Toan");
                    //f = new ThongKeBaoCao();
                    break;
                default:
                    break;
            };
            

        }

       


        #region TabControl
        void RemoveTabpage()
        {
            tabControlQL.TabPages.Remove(tpNhanVien);
            tabControlQL.TabPages.Remove(tpPhong);
            tabControlQL.TabPages.Remove(tpLoaiPhong);
            tabControlQL.TabPages.Remove(tpKhachHang);
            tabControlQL.TabPages.Remove(tpTinhTrang);
            tabControlQL.TabPages.Remove(tpDichVu);
            tabControlQL.TabPages.Remove(tpChucDanh);

        }
        void RemovePhong()
        {
            tabControlQL.TabPages.Remove(tpPhong);
            tabControlQL.TabPages.Remove(tpLoaiPhong);
            tabControlQL.TabPages.Remove(tpTinhTrang);

        }
        void RemoveNhanVien()
        {
            tabControlQL.TabPages.Remove(tpNhanVien);
            tabControlQL.TabPages.Remove(tpChucDanh);
        }
        void RemoveKhachHang()
        {
            tabControlQL.TabPages.Remove(tpKhachHang);
        }
        void RemovDichVu()
        {
            tabControlQL.TabPages.Remove(tpDichVu);
        }
        void AddPhong()
        {
            RemoveTabpage();
            tabControlQL.TabPages.Add(tpLoaiPhong);
            tabControlQL.TabPages.Add(tpTinhTrang);
            tabControlQL.TabPages.Add(tpPhong);
            
        }
        void AddNhanVien()
        {
            RemoveTabpage();
            tabControlQL.TabPages.Add(tpChucDanh);
            tabControlQL.TabPages.Add(tpNhanVien);
            
        }
        void AddKhachHang()
        {
            RemoveTabpage();
            tabControlQL.TabPages.Add(tpKhachHang);
        }
        void AddDichVu()
        {
            RemoveTabpage();
            tabControlQL.TabPages.Add(tpDichVu);
            dtgvDichVu.DataSource = db.LoadDichVu();
        }
        #endregion

        #region MoTabControl

        public void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlQL.Visible = true;
            AddPhong();
            dtgvLoaiPhong.DataSource = db.LoadLoaiPhong();
            dtgvTinhTrang.DataSource = db.LoadTinhTrang();
            dtgvPhong.DataSource = db.LoadPhong();
            HienChiTiet(false);
            btLuu.Enabled = false;

            HienTT(false);
            btLuuTT.Enabled = false;

            HienP(false);
            btLuuP.Enabled = false;
            
        }

        private void nhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlQL.Visible = true;
            AddNhanVien();
            dtgvChucDanh.DataSource = db.LoadChucDanh();
            dtgvNhanVien.DataSource = db.LoadNhanVien();
            HienCD(false);
            btLuuCD.Enabled = false;

            HienNV(false);
            btLuuNV.Enabled = false;
            
        }
        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlQL.Visible = true;
            AddDichVu();
            dtgvChucDanh.DataSource = db.LoadDichVu();
            HienDV(false);
            btLuuDV.Enabled = false;
        }
        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlQL.Visible = true;
            AddKhachHang();
            dtgvKhachHang.DataSource = db.LoadKhachHang();
            HienKH(false);
            btLuuKH.Enabled = false;
        }
        private void phiếuThuêPhòngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtTenKH f = new txtTenKH();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void phiếuDịchVụToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DSPhieuDV f = new DSPhieuDV();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void hoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DSHoaDon f = new DSHoaDon();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void thôngTinCáNhânToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TTCN f = new TTCN();
            f.ShowDialog();
        }
        private void đổiMậtKhẩuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DoiMatKhau f = new DoiMatKhau();
            f.ShowDialog();
        }

        #endregion

        #region LoaiPhong

        #region Method
        private void HienChiTiet(Boolean hien)
        {
            txtID.Enabled = hien;
            txtGia.Enabled = hien;
            txtSoGiuong.Enabled = hien;
            txtSoNguoi.Enabled = hien;
            txtTen.Enabled = hien;
            btXoa.Enabled = hien;
            btThem.Enabled = hien;
            btSua.Enabled = hien;
        }
        //void LoadLoaiPhong(String sql)
        //{
        //    ds = new DataSet();
        //    dap = new SqlDataAdapter(sql, con);
        //    dap.Fill(ds);
        //    dtgvLoaiPhong.DataSource = ds.Tables[0];
        //    dtgvLoaiPhong.Refresh();


        //}

        //kiem tra du lieu nhap vao textbox
        private void KiemTra()
        {
            if (txtID.Text.Trim() == "")
            {
                errChiTiet.SetError(txtID, "Bạn không để trống!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (txtTen.Text.Trim() == "")
            {
                errChiTiet.SetError(txtTen, "Bạn không để trống!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (txtGia.Text.Trim() == "")
            {
                errChiTiet.SetError(txtGia, "Bạn không để trống!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (txtSoGiuong.Text.Trim() == "")
            {
                errChiTiet.SetError(txtSoGiuong, "Bạn không để trống!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (txtSoNguoi.Text.Trim() == "")
            {
                errChiTiet.SetError(txtSoNguoi, "Bạn không để trống!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (String.IsNullOrEmpty(txtID.Text) == true || String.IsNullOrEmpty(txtGia.Text) == true || String.IsNullOrEmpty(txtTen.Text) == true
                || String.IsNullOrEmpty(txtSoGiuong.Text) == true || String.IsNullOrEmpty(txtSoNguoi.Text) == true)
                ktra = false;
            else ktra = true;

        }
        #endregion

        #region Event
        //Binding
        private void dtgvLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btLuu.Enabled = false;
            HienChiTiet(false);
            try
            {
                //txtID.Text = dtgvLoaiPhong[0, e.RowIndex].Value.ToString();
                txtID.Text = dtgvLoaiPhong.CurrentRow.Cells["ID"].Value.ToString();
                txtTen.Text = dtgvLoaiPhong[1, e.RowIndex].Value.ToString();
                txtGia.Text = dtgvLoaiPhong[2, e.RowIndex].Value.ToString();
                txtSoGiuong.Text = dtgvLoaiPhong[3, e.RowIndex].Value.ToString();
                txtSoNguoi.Text = dtgvLoaiPhong[4, e.RowIndex].Value.ToString();
                btThem.Enabled = true;
                btSua.Enabled = true;
                btXoa.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Teng Tèng");

            }

            //txtID.DataBindings.Clear();
            //txtID.DataBindings.Add("Text", dtgvLoaiPhong.DataSource, "ID");
            //txtTen.DataBindings.Clear();
            //txtTen.DataBindings.Add("Text", dtgvLoaiPhong.DataSource, "Ten");
            //txtGia.DataBindings.Clear();
            //txtGia.DataBindings.Add("Text", dtgvLoaiPhong.DataSource, "Gia");
            //txtSoGiuong.DataBindings.Clear();
            //txtSoGiuong.DataBindings.Add("Text", dtgvLoaiPhong.DataSource, "SoGiuong");
            //txtSoNguoi.DataBindings.Clear();
            //txtSoNguoi.DataBindings.Add("Text", dtgvLoaiPhong.DataSource, "SoNguoiToiDaTrenGiuong");
            //HienChiTiet(true);
        }
        //Tim kiem
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            dtgvLoaiPhong.DataSource = db.TimLoaiPhong(txtTim.Text);


        }
        //xoa
        private void btXoa_Click(object sender, EventArgs e)
        {
            //lay Cell hien hanh
            //int id = Convert.ToInt32(dtgvLoaiPhong.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
            if (MessageBox.Show("Bạn có chắc chắn xóa không? ", "Xóa sản phẩm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                int dem = db.Phongs.Where(p => p.IDLoai.Equals(txtID.Text)).Count();
                if (dem > 0)
                {
                    string a = db.Phongs.Where(p => p.IDLoai.Equals(txtID.Text)).First().ID;
                    db.DeletePhong(a);
                    dtgvPhong.DataSource = db.LoadPhong();
                }
                try
                {
                    db.DeleteLoaiPhong(txtID.Text.ToString());
                    MessageBox.Show("Xoá Thành Công");
                    dtgvLoaiPhong.DataSource = db.LoadLoaiPhong();
                }
                catch
                {
                    MessageBox.Show("Xoá Thất bại");
                }
            }
        }
        //insert
        private void btThem_Click_1(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtTen.Text = "";
            txtGia.Text = "";
            txtSoGiuong.Text = "";
            txtSoNguoi.Text = "";
            HienChiTiet(true);

            them = true;
            sua = false;
            btThem.Enabled = false;
            btXoa.Enabled = false;
            btSua.Enabled = false;
            btLuu.Enabled = true;

        }
        //sua
        private void btSua_Click_1(object sender, EventArgs e)
        {
            HienChiTiet(true);
            sua = true;
            them = false;
            btSua.Enabled = false;
            btXoa.Enabled = false;
            btThem.Enabled = false;
            btLuu.Enabled = true;
            txtID.Enabled = false;

        }

        //luu
        private void btLuu_Click(object sender, EventArgs e)
        {
            ktra = false;
            KiemTra();
            if (them == true && ktra == true)
            {

                int dem = db.LoaiPhongs.Where(p => p.ID == txtID.Text).Count();
                if (dem > 0)
                {
                    errChiTiet.SetError(txtID, "ID trùng trong cơ sở dữ liệu");
                    return;
                }

                else
                {
                    try
                    {
                        db.InsertLoaiPhong(txtID.Text.ToString(), txtTen.Text.ToString(), Convert.ToInt32(txtGia.Text), Convert.ToInt32(txtSoGiuong.Text), Convert.ToInt32(txtSoNguoi.Text));
                        MessageBox.Show("Thêm Thành Công");
                        dtgvLoaiPhong.DataSource = db.LoadLoaiPhong();
                        errChiTiet.Clear();
                    }
                    catch
                    {
                        MessageBox.Show("Thêm Thất bại!");
                    }
                }

            }


            if (sua == true && ktra == true)
            {

                try
                {

                    String id = txtID.Text.ToString();
                    String ten = txtTen.Text.ToString();
                    string[] arrListStr = txtGia.Text.Split(',');
                    int gia = Convert.ToInt32(arrListStr[0]);
                    int sg = Convert.ToInt32(txtSoGiuong.Text);
                    int sn = Convert.ToInt32(txtSoNguoi.Text);
                    db.UpdateLoaiPhong(ten, gia, sg, sn, id);
                    MessageBox.Show("Sửa Thành Công");
                    dtgvLoaiPhong.DataSource = db.LoadLoaiPhong();
                }
                catch
                {
                    MessageBox.Show("Sửa Thất bại!");
                }
            }

        }
        #endregion

        #region RangBuocNhapSo
        //chi cho phep nhap so
        private void txtSoGiuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSoNguoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        //chi cho phep nhap ky tu
        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            //if (!System.Text.RegularExpressions.Regex.IsMatch(txtTen.Text, "^[a-zA-Z ]"))
            //{
            //    MessageBox.Show("This textbox accepts only alphabetical characters");
            //    txtTen.Text.Remove(txtTen.Text.Length - 1);
            //}
        }
        #endregion

        #region DieuHuong
        private void btnFirst_Click(object sender, EventArgs e)
        {
            int last = 0;
            dtgvLoaiPhong.CurrentCell = dtgvLoaiPhong.Rows[last].Cells[dtgvLoaiPhong.CurrentCell.ColumnIndex];
            dtgvLoaiPhong.ClearSelection();
            dtgvLoaiPhong.Rows[last].Selected = true;
            DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(0, dtgvLoaiPhong.Rows[last].Index);
            dtgvLoaiPhong_CellClick(sender, ex);

            MessageBox.Show("Đã đầu danh sách");

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int pre = dtgvLoaiPhong.CurrentRow.Index - 1;
            if (pre >= 0)
            {
                dtgvLoaiPhong.CurrentCell = dtgvLoaiPhong.Rows[pre].Cells[dtgvLoaiPhong.CurrentCell.ColumnIndex];
                dtgvLoaiPhong.ClearSelection();
                dtgvLoaiPhong.Rows[pre].Selected = true;

                DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(0, dtgvLoaiPhong.Rows[pre].Index);
                dtgvLoaiPhong_CellClick(sender, ex);

            }
            else
            {
                MessageBox.Show("Đã đầu danh sách");
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int next = dtgvLoaiPhong.CurrentRow.Index + 1;
            if (next < dtgvLoaiPhong.Rows.Count - 1)
            {
                dtgvLoaiPhong.CurrentCell = dtgvLoaiPhong.Rows[next].Cells[dtgvLoaiPhong.CurrentCell.ColumnIndex];
                dtgvLoaiPhong.ClearSelection();
                dtgvLoaiPhong.Rows[next].Selected = true;
                DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(0, dtgvLoaiPhong.Rows[next].Index);
                dtgvLoaiPhong_CellClick(sender, ex);
            }
            else
            {
                MessageBox.Show("Đã cuối danh sách");
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            int last = dtgvLoaiPhong.Rows.Count - 2;
            dtgvLoaiPhong.CurrentCell = dtgvLoaiPhong.Rows[last].Cells[dtgvLoaiPhong.CurrentCell.ColumnIndex];
            dtgvLoaiPhong.ClearSelection();
            dtgvLoaiPhong.Rows[last].Selected = true;


            DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(0, dtgvLoaiPhong.Rows[last].Index);
            dtgvLoaiPhong_CellClick(sender, ex);
            MessageBox.Show("Đã cuối danh sách");
        }
        #endregion

        #endregion

        #region TinhTrangPhong

        #region MethodTTP
        private void HienTT(Boolean hien)
        {
            txtIDTT.Enabled = hien;
            txtTenTT.Enabled = hien;

            btXoaTT.Enabled = hien;
            btThemTT.Enabled = hien;
            btSuaTT.Enabled = hien;
        }
        private void KiemTraTT()
        {
            if (txtIDTT.Text.Trim() == "")
            {
                errChiTiet.SetError(txtIDTT, "Bạn không để trống!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (txtTenTT.Text.Trim() == "")
            {
                errChiTiet.SetError(txtTenTT, "Bạn không để trống!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }

            if (String.IsNullOrEmpty(txtIDTT.Text) == true || String.IsNullOrEmpty(txtTenTT.Text) == true)
                ktraTT = false;
            else ktraTT = true;

        }
        #endregion

        #region EventTTP
        private void txtTimTT_TextChanged(object sender, EventArgs e)
        {
            dtgvTinhTrang.DataSource = db.TimTinhTrangPhong(txtTimTT.Text);
        }

        private void dtgvTinhTrang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btLuuTT.Enabled = false;
            HienTT(false);
            try
            {
                txtIDTT.Text = dtgvTinhTrang[0, e.RowIndex].Value.ToString();
                //txtIDTT.Text = dtgvTinhTrang.CurrentRow.Cells["ID"].Value.ToString();
                txtTenTT.Text = dtgvTinhTrang[1, e.RowIndex].Value.ToString();

                btThemTT.Enabled = true;
                btSuaTT.Enabled = true;
                btXoaTT.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Teng Tèng");

            }
        }
        private void btThemTT_Click(object sender, EventArgs e)
        {
            txtIDTT.Text = "";
            txtTenTT.Text = "";

            HienTT(true);
            themTT = true;
            suaTT = false;
            btThemTT.Enabled = false;
            btXoaTT.Enabled = false;
            btSuaTT.Enabled = false;
            btLuuTT.Enabled = true;
        }

        private void btSuaTT_Click(object sender, EventArgs e)
        {
            HienTT(true);
            suaTT = true;
            themTT = false;
            btSuaTT.Enabled = false;
            btXoaTT.Enabled = false;
            btThemTT.Enabled = false;
            btLuuTT.Enabled = true;
            txtIDTT.Enabled = false;
        }

        private void btXoaTT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không? ", "Xóa sản phẩm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int dem = db.Phongs.Where(p => p.IDTinhTrang.Equals(txtIDTT.Text)).Count();
                if (dem > 0)
                {
                    string a = db.Phongs.Where(p => p.IDTinhTrang.Equals(txtIDTT.Text)).First().ID;
                    db.DeletePhong(a);
                    dtgvPhong.DataSource = db.LoadPhong();
                }
                try
                {
                    db.DeleteTinhTrang(txtIDTT.Text.ToString());
                    MessageBox.Show("Xoá Thành Công");
                    dtgvTinhTrang.DataSource = db.LoadTinhTrang();
                }
                catch
                {
                    MessageBox.Show("Xoá Thất bại");
                }
            }
        }

        private void btLuuTT_Click(object sender, EventArgs e)
        {
            ktraTT = false;
            KiemTraTT();
            if (themTT == true && ktraTT == true)
            {

                int dem = db.TinhTrangPhongs.Where(p => p.ID == txtIDTT.Text).Count();
                if (dem > 0)
                {
                    errChiTiet.SetError(txtIDTT, "ID trùng trong cơ sở dữ liệu");
                    return;
                }

                else
                {

                    try
                    {
                        db.InserTinhTrang(txtIDTT.Text.ToString(), txtTenTT.Text.ToString());
                        MessageBox.Show("Thêm Thành Công");
                        dtgvTinhTrang.DataSource = db.LoadTinhTrang();
                        errChiTiet.Clear();
                    }
                    catch
                    {
                        MessageBox.Show("Thêm Thất bại!");
                    }
                }

            }


            if (suaTT == true && ktraTT == true)
            {

                try
                {
                    db.UpdateTinhTrang(txtTenTT.Text, txtIDTT.Text);
                    MessageBox.Show("Sửa Thành Công");
                    dtgvTinhTrang.DataSource = db.LoadTinhTrang();
                }
                catch
                {
                    MessageBox.Show("Sửa Thất bại!");
                }
            }
        }

        
        #endregion

        #region DieuHuongTTP
        private void btnFirstTT_Click_1(object sender, EventArgs e)
        {
            int last = 0;
            dtgvTinhTrang.CurrentCell = dtgvTinhTrang.Rows[last].Cells[dtgvTinhTrang.CurrentCell.ColumnIndex];
            dtgvTinhTrang.ClearSelection();
            dtgvTinhTrang.Rows[last].Selected = true;
            DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(0, dtgvTinhTrang.Rows[last].Index);
            dtgvTinhTrang_CellClick(sender, ex);

            MessageBox.Show("Đã đầu danh sách");

        }
        private void btnNextTT_Click(object sender, EventArgs e)
        {
            int pre = dtgvTinhTrang.CurrentRow.Index - 1;
            if (pre >= 0)
            {
                dtgvTinhTrang.CurrentCell = dtgvTinhTrang.Rows[pre].Cells[dtgvTinhTrang.CurrentCell.ColumnIndex];
                dtgvTinhTrang.ClearSelection();
                dtgvTinhTrang.Rows[pre].Selected = true;

                DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(0, dtgvTinhTrang.Rows[pre].Index);
                dtgvTinhTrang_CellClick(sender, ex);

            }
            else
            {
                MessageBox.Show("Đã đầu danh sách");
            }
        }
        private void btnPreviousTT_Click(object sender, EventArgs e)
        {
            int next = dtgvTinhTrang.CurrentRow.Index + 1;
            if (next < dtgvTinhTrang.Rows.Count - 1)
            {
                dtgvTinhTrang.CurrentCell = dtgvTinhTrang.Rows[next].Cells[dtgvTinhTrang.CurrentCell.ColumnIndex];
                dtgvTinhTrang.ClearSelection();
                dtgvTinhTrang.Rows[next].Selected = true;
                DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(0, dtgvTinhTrang.Rows[next].Index);
                dtgvTinhTrang_CellClick(sender, ex);
            }
            else
            {
                MessageBox.Show("Đã cuối danh sách");
            }
        }
        private void btnLastTT_Click(object sender, EventArgs e)
        {
            int last = dtgvTinhTrang.Rows.Count - 2;
            dtgvTinhTrang.CurrentCell = dtgvTinhTrang.Rows[last].Cells[dtgvTinhTrang.CurrentCell.ColumnIndex];
            dtgvTinhTrang.ClearSelection();
            dtgvTinhTrang.Rows[last].Selected = true;


            DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(0, dtgvTinhTrang.Rows[last].Index);
            dtgvTinhTrang_CellClick(sender, ex);
            MessageBox.Show("Đã cuối danh sách");
        }
        #endregion

        #endregion

        #region DICHVU
        #region MethodDV
        private void HienDV(Boolean hien)
        {
            txtIDDV.Enabled = hien;
            txtTenDV.Enabled = hien;
            txtGiaDV.Enabled = hien;

            btXoaDV.Enabled = hien;
            btThemDV.Enabled = hien;
            btSuaDV.Enabled = hien;
        }
        private void KiemTraDV()
        {
            if (txtIDDV.Text.Trim() == "")
            {
                errChiTiet.SetError(txtIDDV, "Bạn không để trống!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (txtTenDV.Text.Trim() == "")
            {
                errChiTiet.SetError(txtTenDV, "Bạn không để trống!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (txtGiaDV.Text.Trim() == "")
            {
                errChiTiet.SetError(txtGiaDV, "Bạn không để trống!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }

            if (String.IsNullOrEmpty(txtIDDV.Text) == true || String.IsNullOrEmpty(txtTenDV.Text) == true || String.IsNullOrEmpty(txtGiaDV.Text) == true)
                ktraDV = false;
            else ktraDV = true;

        }
        #endregion
        #region EventDV
        private void dtgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btLuuDV.Enabled = false;
            HienDV(false);
            try
            {
                txtIDDV.Text = dtgvDichVu[0, e.RowIndex].Value.ToString();
                //txtIDTT.Text = dtgvTinhTrang.CurrentRow.Cells["ID"].Value.ToString();
                txtTenDV.Text = dtgvDichVu[1, e.RowIndex].Value.ToString();
                txtGiaDV.Text = dtgvDichVu[2, e.RowIndex].Value.ToString();

                btThemDV.Enabled = true;
                btSuaDV.Enabled = true;
                btXoaDV.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Teng Tèng");

            }
        }
        private void txtTimDV_TextChanged(object sender, EventArgs e)
        {
            dtgvDichVu.DataSource = db.TimDichVu(txtTimDV.Text);

        }
        private void btXoaDV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không? ", "Xóa sản phẩm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    db.DeleteDichVu(txtIDDV.Text.ToString());
                    MessageBox.Show("Xoá Thành Công");
                    dtgvDichVu.DataSource = db.LoadDichVu();
                }
                catch
                {
                    MessageBox.Show("Xoá Thất bại");
                }
            }
        }
        private void btThemDV_Click(object sender, EventArgs e)
        {
            txtIDDV.Text = "";
            txtTenDV.Text = "";
            txtGiaDV.Text = "";

            HienDV(true);
            themDV = true;
            suaDV = false;
            btThemDV.Enabled = false;
            btXoaDV.Enabled = false;
            btSuaDV.Enabled = false;
            btLuuDV.Enabled = true;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void btSuaDV_Click(object sender, EventArgs e)
        {
            HienDV(true);
            suaDV = true;
            themDV = false;
            btSuaDV.Enabled = false;
            btXoaDV.Enabled = false;
            btThemDV.Enabled = false;
            btLuuDV.Enabled = true;
            txtIDDV.Enabled = false;
        }
        private void btLuuDV_Click(object sender, EventArgs e)
        {
            ktraDV = false;
            KiemTraDV();
            if (themDV == true && ktraDV == true)
            {

                int dem = db.DichVus.Where(p => p.ID == txtIDDV.Text).Count();
                if (dem > 0)
                {
                    errChiTiet.SetError(txtIDDV, "ID trùng trong cơ sở dữ liệu");
                    return;
                }

                else
                {

                    try
                    {
                        db.InserDichVu(txtIDDV.Text.ToString(), txtTenDV.Text.ToString(), Convert.ToInt32(txtGiaDV.Text));
                        MessageBox.Show("Thêm Thành Công");
                        dtgvDichVu.DataSource = db.LoadDichVu();
                        errChiTiet.Clear();
                    }
                    catch
                    {
                        MessageBox.Show("Thêm Thất bại!");
                    }
                }

            }


            if (suaDV == true && ktraDV == true)
            {

                try
                {
                    string[] arr = txtGiaDV.Text.Split(',');
                    int gia = Convert.ToInt32(arr[0]);
                    db.UpdateDichVu(txtTenDV.Text, Convert.ToInt32(gia), txtIDDV.Text);
                    MessageBox.Show("Sửa Thành Công");
                    dtgvDichVu.DataSource = db.LoadDichVu();
                }
                catch
                {
                    MessageBox.Show("Sửa Thất bại!");
                }
            }
        }


        #endregion
        #region DieuHuongDV
        private void btFirstDV_Click(object sender, EventArgs e)
        {
            int last = 0;
            dtgvDichVu.CurrentCell = dtgvDichVu.Rows[last].Cells[dtgvDichVu.CurrentCell.ColumnIndex];
            dtgvDichVu.ClearSelection();
            dtgvDichVu.Rows[last].Selected = true;
            DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(0, dtgvDichVu.Rows[last].Index);
            dtgvDichVu_CellClick(sender, ex);

            MessageBox.Show("Đã đầu danh sách");
        }
        private void btNextDV_Click(object sender, EventArgs e)
        {
            int pre = dtgvDichVu.CurrentRow.Index - 1;
            if (pre >= 0)
            {
                dtgvDichVu.CurrentCell = dtgvDichVu.Rows[pre].Cells[dtgvDichVu.CurrentCell.ColumnIndex];
                dtgvDichVu.ClearSelection();
                dtgvDichVu.Rows[pre].Selected = true;

                DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(0, dtgvDichVu.Rows[pre].Index);
                dtgvDichVu_CellClick(sender, ex);

            }
            else
            {
                MessageBox.Show("Đã đầu danh sách");
            }
        }
        private void btPreDV_Click(object sender, EventArgs e)
        {
            int next = dtgvDichVu.CurrentRow.Index + 1;
            if (next < dtgvDichVu.Rows.Count - 1)
            {
                dtgvDichVu.CurrentCell = dtgvDichVu.Rows[next].Cells[dtgvDichVu.CurrentCell.ColumnIndex];
                dtgvDichVu.ClearSelection();
                dtgvDichVu.Rows[next].Selected = true;
                DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(0, dtgvDichVu.Rows[next].Index);
                dtgvDichVu_CellClick(sender, ex);
            }
            else
            {
                MessageBox.Show("Đã cuối danh sách");
            }
        }
        private void btLastDV_Click(object sender, EventArgs e)
        {
            int last = dtgvDichVu.Rows.Count - 2;
            dtgvDichVu.CurrentCell = dtgvDichVu.Rows[last].Cells[dtgvDichVu.CurrentCell.ColumnIndex];
            dtgvDichVu.ClearSelection();
            dtgvDichVu.Rows[last].Selected = true;


            DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(0, dtgvDichVu.Rows[last].Index);
            dtgvDichVu_CellClick(sender, ex);
            MessageBox.Show("Đã cuối danh sách");
        }


        #endregion
        private void txtGiaDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        #endregion

        #region KHACHHANG
        #region MethodKH
        private void HienKH(Boolean hien)
        {
            txtIDKH.Enabled = hien;
            txtTenKH.Enabled = hien;
            dtpNgaySinh.Enabled = hien;
            cbGioiTinhKH.Enabled = hien;
            txtEmailKH.Enabled = hien;
            txtCMNDKH.Enabled = hien;
            txtSDTKH.Enabled = hien;
            txtQuocTichKh.Enabled = hien;
            txtGhiChuKH.Enabled = hien;

            btXoaKH.Enabled = hien;
            btThemKH.Enabled = hien;
            btSuaKH.Enabled = hien;
        }
        private void KiemTraKH()
        {
            if (txtIDKH.Text.Trim() == "")
            {
                errChiTiet.SetError(txtIDKH, "Bạn không để trống!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (txtTenKH.Text.Trim() == "")
            {
                errChiTiet.SetError(txtTenKH, "Bạn không để trống!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (Convert.ToInt32(DateTime.Now.Year - dtpNgaySinh.Value.Year) < 18)
            {
                errChiTiet.SetError(dtpNgaySinh, "Khách hàng phải trên 18 tuổi!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (cbGioiTinhKH.Text.Trim() == "")
            {
                errChiTiet.SetError(cbGioiTinhKH, "Bạn không để trống!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (txtEmailKH.Text.Trim() == "")
            {
                errChiTiet.SetError(txtEmailKH, "Bạn không để trống!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (txtSDTKH.Text.Trim() == "")
            {
                errChiTiet.SetError(txtSDTKH, "Bạn không để trống!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (txtSDTKH.Text.Length != 10)
            {
                errChiTiet.SetError(txtSDTKH, "SDT không đúng!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (txtCMNDKH.Text.Trim() == "")
            {
                errChiTiet.SetError(txtCMNDKH, "Bạn không để trống!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (txtCMNDKH.Text.Length != 9)
            {
                errChiTiet.SetError(txtCMNDKH, "CMND không đúng!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (txtQuocTichKh.Text.Trim() == "")
            {
                errChiTiet.SetError(txtQuocTichKh, "Bạn không để trống!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (String.IsNullOrEmpty(txtIDKH.Text) == true || String.IsNullOrEmpty(txtTenKH.Text) == true || String.IsNullOrEmpty(cbGioiTinhKH.Text) == true
                || String.IsNullOrEmpty(txtEmailKH.Text) == true || String.IsNullOrEmpty(txtSDTKH.Text) == true || String.IsNullOrEmpty(txtCMNDKH.Text) == true
                || String.IsNullOrEmpty(txtQuocTichKh.Text) == true || txtCMNDKH.Text.Length != 9 || txtSDTKH.Text.Length != 10 
                || dtpNgaySinh.Value.Year > (DateTime.Now.Year - 18) )
                ktraKH = false;
            else ktraKH = true;

        }

        #endregion
        #region EventKH
        private void dtgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btLuuKH.Enabled = false;
            HienKH(false);
            try
            {
                txtIDKH.Text = dtgvKhachHang[0, e.RowIndex].Value.ToString();
                txtTenKH.Text = dtgvKhachHang[1, e.RowIndex].Value.ToString();
                dtpNgaySinh.Value = (DateTime)dtgvKhachHang[2, e.RowIndex].Value;
                cbGioiTinhKH.Text = dtgvKhachHang[3, e.RowIndex].Value.ToString();
                txtEmailKH.Text = dtgvKhachHang[4, e.RowIndex].Value.ToString();
                txtSDTKH.Text = dtgvKhachHang[5, e.RowIndex].Value.ToString();
                txtCMNDKH.Text = dtgvKhachHang[6, e.RowIndex].Value.ToString();
                txtQuocTichKh.Text = dtgvKhachHang[7, e.RowIndex].Value.ToString();
                txtGhiChuKH.Text = dtgvKhachHang[8, e.RowIndex].Value.ToString();

                btThemKH.Enabled = true;
                btSuaKH.Enabled = true;
                btXoaKH.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Teng Tèng");

            }
        }
        private void txtTimKH_TextChanged(object sender, EventArgs e)
        {
            dtgvKhachHang.DataSource = db.TimKhachHang(txtTimKH.Text);
        }
        private void btXoaKH_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không? ", "Xóa sản phẩm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int dem = db.PhieuThuePhongs.Where(p => p.IDKhachHang == txtIDKH.Text).Count();
                MessageBox.Show("" + dem);
                if (dem > 0)
                {
                    if (db.PhieuThuePhongs.Where(p => p.IDKhachHang == txtIDKH.Text && p.TinhTrang== "Đang Thuê").Count() > 0 )
                        MessageBox.Show("Khách hàng đang thuê phòng!");
                    else
                    {
                        for(int i=0; i<dem; i++)
                        {
                            //string text = db.PhieuThuePhongs.Where(p => p.IDKhachHang == txtIDKH.Text).ElementAt(i).ID;
                            string idpt = db.PhieuThuePhongs.Where(p => p.IDKhachHang == txtIDKH.Text).First().ID;
                            int idhd = db.HoaDons.Where(p => p.IDThue == idpt).First().ID;
                            db.DeleteHoaDon(idhd);
                            try
                            {
                                int iddv = db.PhieuDichvus.Where(p => p.IDPhieuThue == idpt).First().ID;
                                db.XoaPDV(iddv);
                                
                            }
                            catch
                            {
                            }
                            db.DeletePhieuThue(idpt);
                        }
                        db.DeleteKhachHang(txtIDKH.Text.ToString());
                        MessageBox.Show("Xoá Thành Công");
                        dtgvKhachHang.DataSource = db.LoadKhachHang();
                    }
                }
                else
                {
                    db.DeleteKhachHang(txtIDKH.Text.ToString());
                    MessageBox.Show("Xoá Thành Công");
                    dtgvKhachHang.DataSource = db.LoadKhachHang();
                }
                try
                {
                    
                }
                catch
                {
                    MessageBox.Show("Xoá Thất bại");
                }
            }
        }
        private void btThemKH_Click(object sender, EventArgs e)
        {
            txtIDKH.Text = "";
            txtTenKH.Text = "";
            dtpNgaySinh.Value = DateTime.Now.Date;
            cbGioiTinhKH.TabIndex = 0;
            txtEmailKH.Text = "";
            txtSDTKH.Text = "";
            txtCMNDKH.Text = "";
            txtQuocTichKh.Text = "";
            txtGhiChuKH.Text = "";

            HienKH(true);
            themKH = true;
            suaKH = false;
            btThemKH.Enabled = false;
            btXoaKH.Enabled = false;
            btSuaKH.Enabled = false;
            btLuuKH.Enabled = true;
        }
        private void btSuaKH_Click(object sender, EventArgs e)
        {
            HienKH(true);
            suaKH = true;
            themKH = false;
            btSuaKH.Enabled = false;
            btXoaKH.Enabled = false;
            btThemKH.Enabled = false;
            btLuuKH.Enabled = true;
            txtIDKH.Enabled = false;
        }
        private void btLuuKH_Click(object sender, EventArgs e)
        {
            ktraKH = false;
            KiemTraKH();
            if (themKH == true && ktraKH == true)
            {

                int dem = db.KhachHangs.Where(p => p.ID == txtIDKH.Text).Count();
                if (dem > 0)
                {
                    errChiTiet.SetError(txtIDKH, "ID trùng trong cơ sở dữ liệu");
                    return;
                }

                else
                {

                    try
                    {
                        db.InsertKhachHang(txtIDKH.Text.ToString(), txtTenKH.Text.ToString(), dtpNgaySinh.Value.Date, cbGioiTinhKH.Text, txtEmailKH.Text,
                            txtSDTKH.Text, Convert.ToInt32(txtCMNDKH.Text), txtQuocTichKh.Text, txtGhiChuKH.Text);
                        MessageBox.Show("Thêm Thành Công");
                        dtgvKhachHang.DataSource = db.LoadKhachHang();
                        errChiTiet.Clear();
                    }
                    catch
                    {
                        MessageBox.Show("Thêm Thất bại!");
                    }
                }

            }


            if (suaKH == true && ktraKH == true)
            {

                try
                {
                    db.UpdateKhachHang(txtTenKH.Text.ToString(), dtpNgaySinh.Value.Date, cbGioiTinhKH.Text, txtEmailKH.Text,
                            txtSDTKH.Text, Convert.ToInt32(txtCMNDKH.Text), txtQuocTichKh.Text, txtGhiChuKH.Text, txtIDKH.Text.ToString());
                    MessageBox.Show("Sửa Thành Công");
                    dtgvKhachHang.DataSource = db.LoadKhachHang();
                }
                catch
                {
                    MessageBox.Show("Sửa Thất bại!");
                }
            }
        }
        #endregion
        #region DieuHuongKH
        private void btFirstKH_Click(object sender, EventArgs e)
        {
            int last = 0;
            dtgvKhachHang.CurrentCell = dtgvKhachHang.Rows[last].Cells[dtgvKhachHang.CurrentCell.ColumnIndex];
            dtgvKhachHang.ClearSelection();
            dtgvKhachHang.Rows[last].Selected = true;
            DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(0, dtgvKhachHang.Rows[last].Index);
            dtgvKhachHang_CellClick(sender, ex);

            MessageBox.Show("Đã đầu danh sách");
        }

        private void btNextKH_Click(object sender, EventArgs e)
        {
            int pre = dtgvKhachHang.CurrentRow.Index - 1;
            if (pre >= 0)
            {
                dtgvKhachHang.CurrentCell = dtgvKhachHang.Rows[pre].Cells[dtgvKhachHang.CurrentCell.ColumnIndex];
                dtgvKhachHang.ClearSelection();
                dtgvKhachHang.Rows[pre].Selected = true;

                DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(0, dtgvKhachHang.Rows[pre].Index);
                dtgvKhachHang_CellClick(sender, ex);

            }
            else
            {
                MessageBox.Show("Đã đầu danh sách");
            }
        }

        private void btPreKH_Click(object sender, EventArgs e)
        {
            int next = dtgvKhachHang.CurrentRow.Index + 1;
            if (next < dtgvKhachHang.Rows.Count - 1)
            {
                dtgvKhachHang.CurrentCell = dtgvKhachHang.Rows[next].Cells[dtgvKhachHang.CurrentCell.ColumnIndex];
                dtgvKhachHang.ClearSelection();
                dtgvKhachHang.Rows[next].Selected = true;
                DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(0, dtgvKhachHang.Rows[next].Index);
                dtgvKhachHang_CellClick(sender, ex);
            }
            else
            {
                MessageBox.Show("Đã cuối danh sách");
            }
        }

        private void btLastKH_Click(object sender, EventArgs e)
        {
            int last = dtgvKhachHang.Rows.Count - 2;
            dtgvKhachHang.CurrentCell = dtgvKhachHang.Rows[last].Cells[dtgvKhachHang.CurrentCell.ColumnIndex];
            dtgvKhachHang.ClearSelection();
            dtgvKhachHang.Rows[last].Selected = true;


            DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(0, dtgvKhachHang.Rows[last].Index);
            dtgvKhachHang_CellClick(sender, ex);
            MessageBox.Show("Đã cuối danh sách");
        }

        #endregion

        #region RangBuocNhapSo
        private void txtSDTKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtCMNDKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        #endregion
        #endregion

        #region CHUCDANH
        #region MethodDV
        private void HienCD(Boolean hien)
        {
            txtIDCD.Enabled = hien;
            txtTenCD.Enabled = hien;
            txtRoleCD.Enabled = hien;

            btXoaCD.Enabled = hien;
            btThemCD.Enabled = hien;
            btSuaCD.Enabled = hien;
        }
        private void KiemTraCD()
        {
            if (txtIDCD.Text.Trim() == "")
            {
                errChiTiet.SetError(txtIDCD, "Bạn không để trống!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (txtTenCD.Text.Trim() == "")
            {
                errChiTiet.SetError(txtTenCD, "Bạn không để trống!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (txtRoleCD.Text.Trim() == "")
            {
                errChiTiet.SetError(txtRoleCD, "Bạn không để trống!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }

            if (String.IsNullOrEmpty(txtIDCD.Text) == true || String.IsNullOrEmpty(txtTenCD.Text) == true || String.IsNullOrEmpty(txtRoleCD.Text) == true)
                ktraCD = false;
            else ktraCD = true;

        }
        #endregion
        #region EventCD
        private void dtgvChucDanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btLuuCD.Enabled = false;
            HienCD(false);
            try
            {
                txtIDCD.Text = dtgvChucDanh[0, e.RowIndex].Value.ToString();
                //txtIDTT.Text = dtgvTinhTrang.CurrentRow.Cells["ID"].Value.ToString();
                txtTenCD.Text = dtgvChucDanh[1, e.RowIndex].Value.ToString();
                txtRoleCD.Text = dtgvChucDanh[2, e.RowIndex].Value.ToString();

                btThemCD.Enabled = true;
                btSuaCD.Enabled = true;
                btXoaCD.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Teng Tèng");

            }
        }

        private void txtTimCD_TextChanged(object sender, EventArgs e)
        {
            dtgvChucDanh.DataSource = db.TimChucDanh(txtTimCD.Text);
        }
        private void btXoaCD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không? ", "Xóa sản phẩm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                try
                {
                    int dem = db.NhanViens.Where(p => p.IDChucDanh.Equals(txtIDCD.Text)).Count();
                    if (dem > 0)
                    {
                        string nv = db.TimNVXoa(txtIDCD.Text).First().ID;
                        db.DeleteNhanVien(nv);
                        dtgvNhanVien.DataSource = db.LoadNhanVien();
                    }
                    db.DeleteChucDanh(txtIDCD.Text.ToString());
                    MessageBox.Show("Xoá Thành Công");
                    dtgvChucDanh.DataSource = db.LoadChucDanh();
                }
                catch
                {
                    MessageBox.Show("Xoá Thất bại");
                }
            }
        }

        private void btThemCD_Click(object sender, EventArgs e)
        {
            txtIDCD.Text = "";
            txtTenCD.Text = "";
            txtRoleCD.Text = "";

            HienCD(true);
            themCD = true;
            suaCD = false;
            btThemCD.Enabled = false;
            btXoaCD.Enabled = false;
            btSuaCD.Enabled = false;
            btLuuCD.Enabled = true;
        }

        private void btSuaCD_Click(object sender, EventArgs e)
        {
            HienCD(true);
            suaCD = true;
            themCD = false;
            btSuaCD.Enabled = false;
            btXoaCD.Enabled = false;
            btThemCD.Enabled = false;
            btLuuCD.Enabled = true;
            txtIDCD.Enabled = false;
        }

        private void btLuuCD_Click(object sender, EventArgs e)
        {
            ktraCD = false;
            KiemTraCD();
            if (themCD == true && ktraCD == true)
            {

                int dem = db.ChucDanhs.Where(p => p.ID == txtIDCD.Text).Count();
                if (dem > 0)
                {
                    errChiTiet.SetError(txtIDCD, "ID trùng trong cơ sở dữ liệu");
                    return;
                }

                else
                {

                    try
                    {
                        db.InserChucDanh(txtIDCD.Text.ToString(), txtTenCD.Text.ToString(),Convert.ToInt32(txtRoleCD.Text));
                        MessageBox.Show("Thêm Thành Công");
                        dtgvChucDanh.DataSource = db.LoadChucDanh();
                        errChiTiet.Clear();
                    }
                    catch
                    {
                        MessageBox.Show("Thêm Thất bại!");
                    }
                }

            }


            if (suaCD == true && ktraCD == true)
            {

                try
                {
                    db.UpdateChucDanh(txtTenCD.Text, Convert.ToInt32(txtRoleCD.Text), txtIDCD.Text);
                    MessageBox.Show("Sửa Thành Công");
                    dtgvChucDanh.DataSource = db.LoadChucDanh();
                }
                catch
                {
                    MessageBox.Show("Sửa Thất bại!");
                }
            }
        }
  
        #endregion

        #region DieuHuongCD
        private void btFirstCD_Click(object sender, EventArgs e)
        {
            int last = 0;
            dtgvChucDanh.CurrentCell = dtgvChucDanh.Rows[last].Cells[dtgvChucDanh.CurrentCell.ColumnIndex];
            dtgvChucDanh.ClearSelection();
            dtgvChucDanh.Rows[last].Selected = true;
            DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(0, dtgvChucDanh.Rows[last].Index);
            dtgvChucDanh_CellClick(sender, ex);

            MessageBox.Show("Đã đầu danh sách");
        }

        private void btNextCD_Click(object sender, EventArgs e)
        {
            int pre = dtgvChucDanh.CurrentRow.Index - 1;
            if (pre >= 0)
            {
                dtgvChucDanh.CurrentCell = dtgvChucDanh.Rows[pre].Cells[dtgvChucDanh.CurrentCell.ColumnIndex];
                dtgvChucDanh.ClearSelection();
                dtgvChucDanh.Rows[pre].Selected = true;

                DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(0, dtgvChucDanh.Rows[pre].Index);
                dtgvChucDanh_CellClick(sender, ex);

            }
            else
            {
                MessageBox.Show("Đã đầu danh sách");
            }
        }

        private void btPreCD_Click(object sender, EventArgs e)
        {
            int next = dtgvChucDanh.CurrentRow.Index + 1;
            if (next < dtgvChucDanh.Rows.Count - 1)
            {
                dtgvChucDanh.CurrentCell = dtgvChucDanh.Rows[next].Cells[dtgvChucDanh.CurrentCell.ColumnIndex];
                dtgvChucDanh.ClearSelection();
                dtgvChucDanh.Rows[next].Selected = true;
                DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(0, dtgvChucDanh.Rows[next].Index);
                dtgvChucDanh_CellClick(sender, ex);
            }
            else
            {
                MessageBox.Show("Đã cuối danh sách");
            }
        }

        private void btLastCD_Click(object sender, EventArgs e)
        {
            int last = dtgvChucDanh.Rows.Count - 2;
            dtgvChucDanh.CurrentCell = dtgvChucDanh.Rows[last].Cells[dtgvChucDanh.CurrentCell.ColumnIndex];
            dtgvChucDanh.ClearSelection();
            dtgvChucDanh.Rows[last].Selected = true;


            DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(0, dtgvChucDanh.Rows[last].Index);
            dtgvChucDanh_CellClick(sender, ex);
            MessageBox.Show("Đã cuối danh sách");
        }

        private void txtRoleCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        #endregion

        #endregion

        #region NHANVIEN
        #region MethodNV
        private void HienNV(Boolean hien)
        {
            lbMatKhau.Visible = hien;
            txtMatKhauNV.Visible = hien;
            txtIDNV.Enabled = hien;
            txtTenNV.Enabled = hien;
            dtpNgaySinhNV.Enabled = hien;
            cbGioiTinhNV.Enabled = hien;
            txtDiaChiNV.Enabled = hien;
            txtSDTNV.Enabled = hien;
            txtMatKhauNV.Enabled = hien;
            cbChucDanhNV.Enabled = hien;

            btXoaNV.Enabled = hien;
            btThemNV.Enabled = hien;
            btSuaNV.Enabled = hien;
        }
        private void KiemTraNV()
        {
            if (txtIDNV.Text.Trim() == "")
            {
                errChiTiet.SetError(txtIDNV, "Bạn không để trống!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (txtTenNV.Text.Trim() == "")
            {
                errChiTiet.SetError(txtTenNV, "Bạn không để trống!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (Convert.ToInt32(DateTime.Now.Year - dtpNgaySinhNV.Value.Year) < 18)
            {
                errChiTiet.SetError(dtpNgaySinhNV, "Nhân viên phải trên 18 tuổi!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (cbGioiTinhNV.Text.Trim() == "")
            {
                errChiTiet.SetError(cbGioiTinhNV, "Bạn không để trống!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (txtDiaChiNV.Text.Trim() == "")
            {
                errChiTiet.SetError(txtDiaChiNV, "Bạn không để trống!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (txtSDTNV.Text.Trim() == "")
            {
                errChiTiet.SetError(txtSDTNV, "Bạn không để trống!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (txtSDTNV.Text.Length != 10)
            {
                errChiTiet.SetError(txtSDTNV, "SDT không đúng!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (txtMatKhauNV.Text.Trim() == "")
            {
                errChiTiet.SetError(txtMatKhauNV, "Bạn không để trống!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (cbChucDanhNV.Text.Trim() == "")
            {
                errChiTiet.SetError(cbChucDanhNV, "Bạn không để trống!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (String.IsNullOrEmpty(txtIDNV.Text) == true || String.IsNullOrEmpty(txtTenNV.Text) == true || String.IsNullOrEmpty(cbGioiTinhNV.Text) == true
                || String.IsNullOrEmpty(txtDiaChiNV.Text) == true || String.IsNullOrEmpty(txtSDTNV.Text) == true || String.IsNullOrEmpty(txtMatKhauNV.Text) == true
                || String.IsNullOrEmpty(cbChucDanhNV.Text) == true || dtpNgaySinhNV.Value.Year > (DateTime.Now.Year - 18) || txtSDTNV.Text.Length != 10)
                ktraNV = false;
            else ktraNV = true;

        }
        #endregion
        #region EventNV
        private void dtgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbChucDanhNV.DataSource = db.ChucDanhs;
            cbChucDanhNV.DisplayMember = "ID";
            cbChucDanhNV.ValueMember = "ID";
            btLuuNV.Enabled = false;
            HienNV(false);
            try
            {
                txtIDNV.Text = dtgvNhanVien[0, e.RowIndex].Value.ToString();
                txtTenNV.Text = dtgvNhanVien[1, e.RowIndex].Value.ToString();
                dtpNgaySinhNV.Value = (DateTime)dtgvNhanVien[2, e.RowIndex].Value;
                cbGioiTinhNV.Text = dtgvNhanVien[3, e.RowIndex].Value.ToString();
                txtDiaChiNV.Text = dtgvNhanVien[4, e.RowIndex].Value.ToString();
                txtSDTNV.Text = dtgvNhanVien[5, e.RowIndex].Value.ToString();
                txtMatKhauNV.Text = dtgvNhanVien[6, e.RowIndex].Value.ToString();
                cbChucDanhNV.Text = dtgvNhanVien[7, e.RowIndex].Value.ToString();

                btThemNV.Enabled = true;
                btSuaNV.Enabled = true;
                btXoaNV.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Teng Tèng");

            }
        }

        private void txtTimNV_TextChanged(object sender, EventArgs e)
        {
            dtgvNhanVien.DataSource = db.TimNhanVien(txtTimNV.Text);
        }

        private void btXoaNV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không? ", "Xóa sản phẩm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    db.DeleteNhanVien(txtIDNV.Text.ToString());
                    MessageBox.Show("Xoá Thành Công");
                    dtgvNhanVien.DataSource = db.LoadNhanVien();
                }
                catch
                {
                    MessageBox.Show("Xoá Thất bại");
                }
            }
        }

        private void btThemNV_Click(object sender, EventArgs e)
        {

            txtIDNV.Text = "";
            txtTenNV.Text = "";
            dtpNgaySinhNV.Value = DateTime.Now.Date;
            cbGioiTinhNV.TabIndex = 0;
            txtDiaChiNV.Text = "";
            txtSDTNV.Text = "";
            txtMatKhauNV.Text = "";
            cbChucDanhNV.TabIndex = 0;

            lbMatKhau.Visible = true;
            txtMatKhauNV.Visible = true;
            HienNV(true);
            themNV = true;
            suaNV = false;
            btThemNV.Enabled = false;
            btXoaNV.Enabled = false;
            btSuaNV.Enabled = false;
            btLuuNV.Enabled = true;
        }

        private void btSuaNV_Click(object sender, EventArgs e)
        {
            HienNV(true);
            lbMatKhau.Visible = false;
            txtMatKhauNV.Visible = false;
            suaNV = true;
            themNV = false;
            btSuaNV.Enabled = false;
            btXoaNV.Enabled = false;
            btThemNV.Enabled = false;
            btLuuNV.Enabled = true;
            txtIDNV.Enabled = false;
        }

        private void btLuuNV_Click(object sender, EventArgs e)
        {
            ktraNV = false;
            KiemTraNV();
            if (themNV == true && ktraNV == true)
            {

                int dem = db.NhanViens.Where(p => p.ID == txtIDNV.Text).Count();
                if (dem > 0)
                {
                    errChiTiet.SetError(txtIDNV, "ID trùng trong cơ sở dữ liệu");
                    return;
                }

                else
                {

                    try
                    {
                        db.InsertNhanVien(txtIDNV.Text.ToString(), txtTenNV.Text.ToString(), dtpNgaySinhNV.Value.Date, cbGioiTinhNV.Text, txtDiaChiNV.Text,
                            txtSDTNV.Text, txtMatKhauNV.Text, cbChucDanhNV.Text);
                        MessageBox.Show("Thêm Thành Công");
                        dtgvNhanVien.DataSource = db.LoadNhanVien();
                        errChiTiet.Clear();
                    }
                    catch
                    {
                        MessageBox.Show("Thêm Thất bại!");
                    }
                }

            }


            if (suaNV == true && ktraNV == true)
            {

                try
                {
                    db.UpdateNhanVien(txtTenNV.Text.ToString(), dtpNgaySinhNV.Value.Date, cbGioiTinhNV.Text, txtDiaChiNV.Text,
                            txtSDTNV.Text, txtMatKhauNV.Text, cbChucDanhNV.Text, txtIDNV.Text.ToString());
                    MessageBox.Show("Sửa Thành Công");
                    dtgvNhanVien.DataSource = db.LoadNhanVien();
                }
                catch
                {
                    MessageBox.Show("Sửa Thất bại!");
                }
            }
        }
        #endregion
        #region DieuHuongNV
        private void btFirstNV_Click(object sender, EventArgs e)
        {
            int last = 0;
            dtgvNhanVien.CurrentCell = dtgvNhanVien.Rows[last].Cells[dtgvNhanVien.CurrentCell.ColumnIndex];
            dtgvNhanVien.ClearSelection();
            dtgvNhanVien.Rows[last].Selected = true;
            DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(0, dtgvNhanVien.Rows[last].Index);
            dtgvNhanVien_CellClick(sender, ex);

            MessageBox.Show("Đã đầu danh sách");
        }

        private void btNextNV_Click(object sender, EventArgs e)
        {
            int pre = dtgvNhanVien.CurrentRow.Index - 1;
            if (pre >= 0)
            {
                dtgvNhanVien.CurrentCell = dtgvNhanVien.Rows[pre].Cells[dtgvNhanVien.CurrentCell.ColumnIndex];
                dtgvNhanVien.ClearSelection();
                dtgvNhanVien.Rows[pre].Selected = true;

                DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(0, dtgvNhanVien.Rows[pre].Index);
                dtgvNhanVien_CellClick(sender, ex);

            }
            else
            {
                MessageBox.Show("Đã đầu danh sách");
            }
        }

        private void btPreNV_Click(object sender, EventArgs e)
        {
            int next = dtgvNhanVien.CurrentRow.Index + 1;
            if (next < dtgvChucDanh.Rows.Count - 1)
            {
                dtgvNhanVien.CurrentCell = dtgvNhanVien.Rows[next].Cells[dtgvNhanVien.CurrentCell.ColumnIndex];
                dtgvNhanVien.ClearSelection();
                dtgvNhanVien.Rows[next].Selected = true;
                DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(0, dtgvNhanVien.Rows[next].Index);
                dtgvNhanVien_CellClick(sender, ex);
            }
            else
            {
                MessageBox.Show("Đã cuối danh sách");
            }
        }
        private void btLastNV_Click(object sender, EventArgs e)
        {
            int last = dtgvNhanVien.Rows.Count - 2;
            dtgvNhanVien.CurrentCell = dtgvNhanVien.Rows[last].Cells[dtgvNhanVien.CurrentCell.ColumnIndex];
            dtgvNhanVien.ClearSelection();
            dtgvNhanVien.Rows[last].Selected = true;


            DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(0, dtgvNhanVien.Rows[last].Index);
            dtgvNhanVien_CellClick(sender, ex);
            MessageBox.Show("Đã cuối danh sách");
        }

        

        private void txtSDTNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        #endregion
        #endregion

        #region PHONG
        #region MethodPhong
        private void HienP(Boolean hien)
        {
            txtIDP.Enabled = hien;
            txtTenP.Enabled = hien;
            cbLoaiPhong.Enabled = hien;
            cbTinhTrangP.Enabled = hien;

            btThuePhong.Enabled = hien;
            btXoaP.Enabled = hien;
            btThemP.Enabled = hien;
            btSuaP.Enabled = hien;
        }
        private void KiemTraP()
        {
            if (txtIDP.Text.Trim() == "")
            {
                errChiTiet.SetError(txtIDP, "Bạn không để trống!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (txtTenP.Text.Trim() == "")
            {
                errChiTiet.SetError(txtTenP, "Bạn không để trống!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
          

            if (String.IsNullOrEmpty(txtIDP.Text) == true || String.IsNullOrEmpty(txtTenP.Text) == true )
                ktraP = false;
            else ktraP = true;

        }
        #endregion
        #region EventPhong
        private void dtgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            cbLoaiPhong.DataSource = db.LoadLoaiPhong();
            cbLoaiPhong.DisplayMember = "Ten";
            cbLoaiPhong.ValueMember = "ID";

            cbTinhTrangP.DataSource = db.LoadTinhTrang();
            cbTinhTrangP.DisplayMember = "Ten";
            cbTinhTrangP.ValueMember = "ID";
            btLuuP.Enabled = false;
            HienP(false);
            try
            {
                txtIDP.Text = dtgvPhong[0, e.RowIndex].Value.ToString();
                txtTenP.Text = dtgvPhong[1, e.RowIndex].Value.ToString();
                cbLoaiPhong.Text = dtgvPhong[2, e.RowIndex].Value.ToString();
                cbTinhTrangP.Text = dtgvPhong[3, e.RowIndex].Value.ToString();

                btThuePhong.Enabled = false;
                btThemP.Enabled = true;
                btSuaP.Enabled = true;
                btXoaP.Enabled = true;
                if (cbTinhTrangP.Text == "Trống") btThuePhong.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Teng Tèng");

            }
        }
        private void txtTimPhong_TextChanged(object sender, EventArgs e)
        {
            dtgvPhong.DataSource = db.TimPhong(txtTimPhong.Text);
        }

        private void btXoaP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không? ", "Xóa sản phẩm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {          
                try
                {
                    db.DeletePhong(txtIDP.Text.ToString());
                    MessageBox.Show("Xoá Thành Công");
                    dtgvPhong.DataSource = db.LoadPhong();
                }
                catch
                {
                    MessageBox.Show("Xoá Thất bại");
                }
            }
        }

        private void btThemP_Click(object sender, EventArgs e)
        {
            
            txtIDP.Text = "";
            txtTenP.Text = "";
            cbLoaiPhong.TabIndex = 0;
            cbTinhTrangP.TabIndex = 0;

            HienP(true);
            themP = true;
            suaP = false;
            btThuePhong.Enabled = false;
            btThemP.Enabled = false;
            btXoaP.Enabled = false;
            btSuaP.Enabled = false;
            btLuuP.Enabled = true;
        }

        private void btSuaP_Click(object sender, EventArgs e)
        {
            
            HienP(true);
            suaP = true;
            themP = false;
            btThuePhong.Enabled = false;
            btSuaP.Enabled = false;
            btXoaP.Enabled = false;
            btThemP.Enabled = false;
            btLuuP.Enabled = true;
            txtIDP.Enabled = false;
        }

        private void btLuuP_Click(object sender, EventArgs e)
        {
            ktraP = false;
            KiemTraP();
            if (themP == true && ktraP == true)
            {

                int dem = db.Phongs.Where(p => p.ID == txtIDP.Text).Count();
                if (dem > 0)
                {
                    errChiTiet.SetError(txtIDP, "ID trùng trong cơ sở dữ liệu");
                    return;
                }

                else
                {

                    try
                    {
                        db.InserPhong(txtIDP.Text.ToString(), txtTenP.Text.ToString(), cbLoaiPhong.SelectedValue.ToString(), cbTinhTrangP.SelectedValue.ToString());
                        MessageBox.Show("Thêm Thành Công");
                        dtgvPhong.DataSource = db.LoadPhong();
                        errChiTiet.Clear();
                    }
                    catch
                    {
                        MessageBox.Show("Thêm Thất bại!");
                    }
                }

            }


            if (suaP == true && ktraP == true)
            {

                try
                {
                    db.UpdatePhong(txtTenP.Text, cbLoaiPhong.SelectedValue.ToString(),cbTinhTrangP.SelectedValue.ToString(), txtIDP.Text);
                    MessageBox.Show("Sửa Thành Công");
                    dtgvPhong.DataSource = db.LoadPhong();
                }
                catch
                {
                    MessageBox.Show("Sửa Thất bại!");
                }
            }
        }
        private void btThuePhong_Click(object sender, EventArgs e)
        {
            Cons.Cons.idPhong = txtIDP.Text;
            Cons.Cons.tenPhong = txtTenP.Text;
            this.phòngToolStripMenuItem_Click(sender, e);
            ThuePhong f = new ThuePhong();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        #endregion
        #region DieuHuongPhong
        private void btFirstP_Click(object sender, EventArgs e)
        {
            int last = 0;
            dtgvPhong.CurrentCell = dtgvPhong.Rows[last].Cells[dtgvPhong.CurrentCell.ColumnIndex];
            dtgvPhong.ClearSelection();
            dtgvPhong.Rows[last].Selected = true;
            DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(0, dtgvPhong.Rows[last].Index);
            dtgvPhong_CellClick(sender, ex);

            MessageBox.Show("Đã đầu danh sách");
        }

        private void btNextP_Click(object sender, EventArgs e)
        {
            int pre = dtgvPhong.CurrentRow.Index - 1;
            if (pre >= 0)
            {
                dtgvPhong.CurrentCell = dtgvPhong.Rows[pre].Cells[dtgvPhong.CurrentCell.ColumnIndex];
                dtgvPhong.ClearSelection();
                dtgvPhong.Rows[pre].Selected = true;

                DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(0, dtgvPhong.Rows[pre].Index);
                dtgvPhong_CellClick(sender, ex);

            }
            else
            {
                MessageBox.Show("Đã đầu danh sách");
            }
        }

        private void btPreP_Click(object sender, EventArgs e)
        {
            int next = dtgvPhong.CurrentRow.Index + 1;
            if (next < dtgvPhong.Rows.Count - 1)
            {
                dtgvPhong.CurrentCell = dtgvPhong.Rows[next].Cells[dtgvPhong.CurrentCell.ColumnIndex];
                dtgvPhong.ClearSelection();
                dtgvPhong.Rows[next].Selected = true;
                DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(0, dtgvPhong.Rows[next].Index);
                dtgvPhong_CellClick(sender, ex);
            }
            else
            {
                MessageBox.Show("Đã cuối danh sách");
            }
        }

        private void btLastP_Click(object sender, EventArgs e)
        {
            int last = dtgvPhong.Rows.Count - 2;
            dtgvPhong.CurrentCell = dtgvPhong.Rows[last].Cells[dtgvPhong.CurrentCell.ColumnIndex];
            dtgvPhong.ClearSelection();
            dtgvPhong.Rows[last].Selected = true;


            DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(0, dtgvPhong.Rows[last].Index);
            dtgvPhong_CellClick(sender, ex);
            MessageBox.Show("Đã cuối danh sách");
        }
        #endregion
        #endregion

    }
}