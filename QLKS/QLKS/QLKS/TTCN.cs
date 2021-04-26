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
    public partial class TTCN : Form
    {
        bool ktraNV = false, sua = false;
        CSDLDataContext db = new CSDLDataContext();
        public TTCN()
        {
            InitializeComponent();
        }
        #region MethodNV
        private void HienNV(Boolean hien)
        {
            txtIDNV.Enabled = hien;
            txtTenNV.Enabled = hien;
            dtpNgaySinhNV.Enabled = hien;
            cbGioiTinhNV.Enabled = hien;
            txtDiaChiNV.Enabled = hien;
            txtSDTNV.Enabled = hien;
            txtMatKhauNV.Enabled = hien;
            //cbChucDanhNV.Enabled = hien;
            
            btLuu.Enabled = hien;
            //btSua.Enabled = hien;
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
        private void btSua_Click(object sender, EventArgs e)
        {
            HienNV(true);
            sua = true;
            btSua.Enabled = false;
            btLuu.Enabled = true;
            txtIDNV.Enabled = false;
        }

        private void TTCN_Load(object sender, EventArgs e)
        {
            HienNV(false);
            lbMatKhau.Visible = false;
            txtMatKhauNV.Visible = false;
            txtIDNV.Text = db.NhanViens.Where(p => p.ID == Cons.Cons.idNhanVien).First().ID;
            txtTenNV.Text = db.NhanViens.Where(p => p.ID == Cons.Cons.idNhanVien).First().Ten;
            dtpNgaySinhNV.Value = (DateTime)db.NhanViens.Where(p => p.ID == Cons.Cons.idNhanVien).First().NgaySinh;
            cbGioiTinhNV.Text = db.NhanViens.Where(p => p.ID == Cons.Cons.idNhanVien).First().GioiTinh;
            txtDiaChiNV.Text = db.NhanViens.Where(p => p.ID == Cons.Cons.idNhanVien).First().DiaChi;
            txtSDTNV.Text = db.NhanViens.Where(p => p.ID == Cons.Cons.idNhanVien).First().SDT;
            txtMatKhauNV.Text = db.NhanViens.Where(p => p.ID == Cons.Cons.idNhanVien).First().Matkhau;
            cbChucDanhNV.Text = db.NhanViens.Where(p => p.ID == Cons.Cons.idNhanVien).First().IDChucDanh;
        }

        private void txtSDTNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            ktraNV = false;
            KiemTraNV();
            if (sua == true && ktraNV == true)
            {

                try
                {
                    db.UpdateNhanVien(txtTenNV.Text.ToString(), dtpNgaySinhNV.Value.Date, cbGioiTinhNV.Text, txtDiaChiNV.Text,
                            txtSDTNV.Text, txtMatKhauNV.Text, cbChucDanhNV.Text, txtIDNV.Text.ToString());
                    MessageBox.Show("Sửa Thành Công");
                    HienNV(false);
                    btSua.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("Sửa Thất bại!");
                }
            }
        }
    }
}
