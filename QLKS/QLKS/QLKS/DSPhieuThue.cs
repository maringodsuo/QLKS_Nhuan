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
    public partial class txtTenKH : Form
    {
        CSDLDataContext db = new CSDLDataContext();
        bool ktraPT = false, them=false, sua=false;
        public txtTenKH()
        {
            InitializeComponent();
        }

        private void DSPhieuThue_Load(object sender, EventArgs e)
        {
            lbTenNhanVien.Text = Cons.Cons.tenNhanVien;

            lbTenNhanVien.Text = Cons.Cons.tenNhanVien;
            dtgvPhieuThueP.DataSource = db.LoadPhieuThue();
            HienPT(false);
            txtTenKhachHang.DataSource = db.LoadKhachHang();
            txtTenKhachHang.DisplayMember = "Ten";
            txtTenKhachHang.ValueMember = "ID";

            txtTenPhong.DataSource = db.LoadPhong();
            txtTenPhong.DisplayMember = "TenPhong";
            txtTenPhong.ValueMember = "ID";

            txtNhanVien.DataSource = db.LoadNhanVien();
            txtNhanVien.DisplayMember = "Ten";
            txtNhanVien.ValueMember = "ID";
        }
        #region MethodPhong
        private void HienPT(Boolean hien)
        {
            txtID.Enabled = hien;
            txtTenKhachHang.Enabled = hien;
            txtTenPhong.Enabled = hien;
            dtpNgayThue.Enabled = hien;
            dtpNgayDi.Enabled = hien;
            txtTienCoc.Enabled = hien;

            btDichvu.Enabled = hien;
            btXoa.Enabled = hien;
            //btThem.Enabled = hien;
            btSua.Enabled = hien;
            btLuu.Enabled = hien;
            btThanhtoan.Enabled = hien;
        }

        private void KiemTraPT()
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
            if (txtTienCoc.Text.Trim() == "")
            {
                errChiTiet.SetError(txtTienCoc, "Bạn không để trống!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (dtpNgayThue.Value.Date < DateTime.Now.Date )
            {
                errChiTiet.SetError(dtpNgayThue, "Kiểm tra ngày thuê!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (dtpNgayDi.Value.Date < dtpNgayThue.Value.Date)
            {
                errChiTiet.SetError(dtpNgayDi, "Kiểm tra ngày đi!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (String.IsNullOrEmpty(txtID.Text) == true || String.IsNullOrEmpty(txtTienCoc.Text) == true || dtpNgayThue.Value.Date < DateTime.Now.Date
                || dtpNgayThue.Value.Date < DateTime.Now.Date)
                ktraPT = false;
            else ktraPT = true;

        }
        #endregion
        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không? ", "Xóa sản phẩm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int dem = db.PhieuDichvus.Where(p => p.IDPhieuThue.Equals(txtID.Text)).Count();
                
                int dem2 = db.HoaDons.Where(p => p.IDThue.Equals(txtID.Text)).Count();
                if (dem2 > 0)
                {
                    int a = db.HoaDons.Where(p => p.IDThue.Equals(txtID.Text)).First().ID;
                    db.DeleteHoaDon(a);
                }
                if (dem > 0)
                {
                    int a = db.PhieuDichvus.Where(p => p.IDPhieuThue.Equals(txtID.Text)).First().ID;
                    db.XoaPDV(a);
                }
                try
                {
                    db.DeletePhieuThue(txtID.Text.ToString());
                    MessageBox.Show("Xoá Thành Công");
                    dtgvPhieuThueP.DataSource = db.LoadPhieuThue();
                }
                catch
                {
                    MessageBox.Show("Xoá Thất bại");
                }
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtTienCoc.Text = "";
            txtTenKhachHang.TabIndex = 0;
            txtNhanVien.TabIndex = 0;
            txtTinhTrang.SelectedIndex = 0;
            txtTenPhong.TabIndex = 0;
            dtpNgayThue.Value = DateTime.Now.Date;
            dtpNgayDi.Value = DateTime.Now.Date;

            HienPT(true);
            them = true;
            sua = false;
            btDichvu.Enabled = false;
            btThanhtoan.Enabled = false;
            btThem.Enabled = false;
            btXoa.Enabled = false;
            btSua.Enabled = false;
            btLuu.Enabled = true;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            HienPT(true);
            txtTenPhong.Enabled = false;
            txtTenKhachHang.Enabled = false;
            sua = true;
            them = false;
            btDichvu.Enabled = false;
            btThanhtoan.Enabled = false;
            btSua.Enabled = false;
            btXoa.Enabled = false;
            btThem.Enabled = false;
            btLuu.Enabled = true;
            txtID.Enabled = false;
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            ktraPT = false;
            KiemTraPT();
            if (them == true && ktraPT == true)
            {
                string thue = db.Phongs.Where(p => p.ID.Equals(txtTenPhong.SelectedValue.ToString())).First().IDTinhTrang;
                int dem = db.PhieuThuePhongs.Where(p => p.ID == txtID.Text).Count();
                if (dem > 0)
                {
                    errChiTiet.SetError(txtID, "ID trùng trong cơ sở dữ liệu");
                    return;
                }
                else
                {
                    if (thue != "1") MessageBox.Show("Phòng được chọn đã có người thuê" + Environment.NewLine + "Vui lòng chọn phòng khác");
                    else
                    {
                        try
                        {
                            
                            db.InsertPhieuThue(txtID.Text, txtTenKhachHang.SelectedValue.ToString(), txtTenPhong.SelectedValue.ToString(), dtpNgayThue.Value.Date,
                                                dtpNgayDi.Value.Date, Convert.ToInt32(txtTienCoc.Text), txtTinhTrang.Text, txtNhanVien.SelectedValue.ToString());
                            MessageBox.Show("Thêm Thành Công");
                            dtgvPhieuThueP.DataSource = db.LoadPhieuThue();
                            errChiTiet.Clear();
                            Phong edit = db.Phongs.Where(p => p.ID.Equals(txtTenPhong.SelectedValue.ToString())).SingleOrDefault();
                            edit.IDTinhTrang = "2";
                            db.SubmitChanges();
                        }
                        catch
                        {
                            MessageBox.Show("Thêm Thất bại!");
                        }
                    }
                }

            }


            if (sua == true && ktraPT == true)
            {

                try
                {
                    string[] arrListStr = txtTienCoc.Text.Split(',');
                    int tiencoc = Convert.ToInt32(arrListStr[0]);
                    db.UpdatePhieuThue(txtID.Text, txtTenKhachHang.SelectedValue.ToString(), txtTenPhong.SelectedValue.ToString(), dtpNgayThue.Value.Date,
                                            dtpNgayDi.Value.Date, tiencoc, txtTinhTrang.Text, txtNhanVien.SelectedValue.ToString());
                    MessageBox.Show("Sửa Thành Công");
                    dtgvPhieuThueP.DataSource = db.LoadPhieuThue();
                }
                catch
                {
                    MessageBox.Show("Sửa Thất bại!");
                }
            }
        }

        private void txtTenPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btThongKe_Click(object sender, EventArgs e)
        {
            dtgvPhieuThueP.DataSource = db.ThongKe(dtpTu.Value.Date, dtpDen.Value.Date);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            DSHoaDon f = new DSHoaDon();
            this.Close();
            f.ShowDialog();
            
        }

        private void btDichvu_Click(object sender, EventArgs e)
        {
            DSPhieuDV f = new DSPhieuDV();
            f.ShowDialog();
            this.Close();
        }

        private void txtTienCoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            dtgvPhieuThueP.DataSource = db.TimPhieuThue(txtTim.Text);
        }
        private void dtgvPhieuThueP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            btLuu.Enabled = false;
            HienPT(false);
            try
            {
                txtID.Text = dtgvPhieuThueP[0, e.RowIndex].Value.ToString();
                txtTenKhachHang.Text = dtgvPhieuThueP[1, e.RowIndex].Value.ToString();
                txtTenPhong.Text = dtgvPhieuThueP[2, e.RowIndex].Value.ToString();
                dtpNgayThue.Value =(DateTime)dtgvPhieuThueP[3, e.RowIndex].Value;
                dtpNgayDi.Value = (DateTime)dtgvPhieuThueP[4, e.RowIndex].Value;
                txtTienCoc.Text = dtgvPhieuThueP[5, e.RowIndex].Value.ToString();
                txtTinhTrang.Text = dtgvPhieuThueP[6, e.RowIndex].Value.ToString();
                txtNhanVien.Text = dtgvPhieuThueP[7, e.RowIndex].Value.ToString();


                if (txtTinhTrang.Text == "Đã thanh toán")
                {
                    btThanhtoan.Enabled = false;
                    btXoa.Enabled = true;
                    btSua.Enabled = false;
                }    
                else
                {
                    btThanhtoan.Enabled = true;
                    btXoa.Enabled = false;
                    btSua.Enabled = true;
                }
                btThem.Enabled = true;
                btDichvu.Enabled = true;
                
            }
            catch (Exception)
            {
                MessageBox.Show("Teng Tèng");

            }
        }

        
    }
}
