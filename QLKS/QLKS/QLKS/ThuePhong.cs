using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    
    public partial class ThuePhong : Form
    {
        bool ktraKH=false, themKH=false, ktraLT=false;
        CSDLDataContext db = new CSDLDataContext();
        public ThuePhong()
        {
            InitializeComponent();
            HienKH(false);
        }
        

        private void ThuePhong_Load(object sender, EventArgs e)
        {
            lbTenNhanVien.Text = Cons.Cons.tenNhanVien;
            dtgvKhachHang.DataSource = db.LoadKhachHang();
        }
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

            //btThemKH.Enabled = hien;
            btLuuKH.Enabled = hien;
            btXacNhanThue.Enabled = hien;
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
                || dtpNgaySinh.Value.Year > (DateTime.Now.Year - 18))
                ktraKH = false;
            else ktraKH = true;

        }
        void KiemTraLichTrinh()
        {
            if (txtTienCoc.Text.Trim() == "")
            {
                errChiTiet.SetError(txtTienCoc, "Bạn không để trống!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (dtpNgayThue.Value.Date < DateTime.Now.Date)
            {
                errChiTiet.SetError(dtpNgayThue, "Kiểm tra lại ngày thuê!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (dtpNgayDI.Value.Date < dtpNgayThue.Value.Date)
            {
                errChiTiet.SetError(dtpNgayDI, "Kiểm tra lại ngày đi!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (String.IsNullOrEmpty(txtTienCoc.Text) == true || dtpNgayThue.Value.Date < DateTime.Now.Date || dtpNgayDI.Value.Date < dtpNgayThue.Value.Date)
                ktraLT = false;
            else ktraLT = true;

        }

        #endregion
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
                btXacNhanThue.Enabled = true;
            }
            catch (Exception)
            {
                int last = 0;
                dtgvKhachHang.CurrentCell = dtgvKhachHang.Rows[last].Cells[dtgvKhachHang.CurrentCell.ColumnIndex];
                dtgvKhachHang.ClearSelection();
                dtgvKhachHang.Rows[last].Selected = true;
                DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(0, dtgvKhachHang.Rows[last].Index);
                dtgvKhachHang_CellClick(sender, ex);
                MessageBox.Show("Vui lòng chọn đúng");

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
            btXacNhanThue.Enabled = false;
            btThemKH.Enabled = false;
            btLuuKH.Enabled = true;
        }

        private void btXacNhanThue_Click(object sender, EventArgs e)
        {
            KiemTraKH();
            KiemTraLichTrinh();
            if (ktraKH == true && ktraLT==true)
            {
                Cons.Cons.tienCoc = Convert.ToInt32(txtTienCoc.Text);
                Cons.Cons.idKhachHang = txtIDKH.Text;
                Cons.Cons.ngayThue = dtpNgayThue.Value.Date;
                Cons.Cons.ngayDi = dtpNgayDI.Value.Date;
                string tt = "Đang thuê";

                string id = (Convert.ToInt32(db.MaxID().First().Column1) + 1).ToString();
                
                
                try
                {
                    db.InsertPhieuThue(id, Cons.Cons.idKhachHang, Cons.Cons.idPhong, Cons.Cons.ngayThue, Cons.Cons.ngayDi, Cons.Cons.tienCoc, tt, Cons.Cons.idNhanVien);
                    MessageBox.Show("Thuê thành công!");
                    errChiTiet.Clear();
                    //Phong edit = db.Phongs.Where(p => p.ID.Equals(Cons.Cons.idPhong)).SingleOrDefault();
                    //edit.IDTinhTrang = "2";
                    //db.SubmitChanges();
                    db.SuaPhong(Cons.Cons.idPhong);

                }
                catch
                {
                    MessageBox.Show("Thêm Thất bại!");
                }
                txtTenKH f = new txtTenKH();
                this.Close();
                f.ShowDialog();
                

            }    
            
        }

        private void txtTimKH_TextChanged(object sender, EventArgs e)
        {
            dtgvKhachHang.DataSource = db.TimKhachHang(txtTimKH.Text);
        }

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

        private void txtTienCoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
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
        }
    }
}
