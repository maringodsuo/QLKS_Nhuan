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
    public partial class DSHoaDon : Form
    {
        CSDLDataContext db = new CSDLDataContext();
        public DSHoaDon()
        {
            InitializeComponent();
        }

        private void DSHoaDon_Load(object sender, EventArgs e)
        {
            lbTenNhanVien.Text = Cons.Cons.tenNhanVien;
            int n = db.PhieuThuePhongs.Where(p => p.TinhTrang.Equals("Đang Thuê")).Count();
            dtgvHoaDon.DataSource = db.LoadHoaDon();
            cbIDThue.DisplayMember = "ID";
            cbIDThue.ValueMember = "ID";
            cbIDThue.DataSource = db.PhieuThuePhongs.Where(p => p.TinhTrang.Equals("Đang Thuê"));
            Hien(false);
            if (cbIDThue.Text.ToString() == "") btThem.Enabled = false;
        }
        void Hien(bool hien)
        {
            txtTenKhachHang.Enabled = hien;
            txtTenPhong.Enabled = hien;
            dtpNgayThue.Enabled = hien;
            dtpNgayDi.Enabled = hien;
            txtTienCoc.Enabled = hien;
            txtTongTienThue.Enabled = hien;
            txtTienThanhToan.Enabled = hien;
            cbIDDV.Enabled = hien;
            txtTienDV.Enabled = hien;
            button1.Enabled = hien;
            //btThem.Enabled = hien;
            btXoa.Enabled = hien;
        }
        private void cbIDThue_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string id = cbIDThue.SelectedValue.ToString();
            txtTenKhachHang.Text  = db.LoadTheoIDThue(id).First().TenKhachHang;
            txtTenPhong.Text = db.LoadPhieuThue().Where(p => p.ID.Equals(id)).First().TenPhong.ToString();
            dtpNgayThue.Value = (DateTime)db.LoadPhieuThue().Where(p => p.ID.Equals(id)).First().NgayThue;
            dtpNgayDi.Value = (DateTime)db.LoadTheoIDThue(id).First().NgayKetThuc.Value;
            txtTienCoc.Text = db.LoadTheoIDThue(id).First().TienCoc.ToString();

            string[] arrListStr = txtTienCoc.Text.Split(',');
            int tiencoc = Convert.ToInt32(arrListStr[0]);
            int songay = (dtpNgayDi.Value.Date - dtpNgayThue.Value.Date).Days;
            if (songay == 0) songay = 1;
            string idP = db.PhieuThuePhongs.Where(p=>p.ID.Equals(id)).First().IDPhong;
            string idL = db.Phongs.Where(p=>p.ID.Equals(idP)).First().IDLoai;
            int gia = Convert.ToInt32(db.LoaiPhongs.Where(p => p.ID.Equals(idL)).First().Gia);
            int tong = (gia * songay);
            txtTongTienThue.Text = tong + ",0000";
            int tienconlai = tong - tiencoc;

            txtTienThanhToan.Text = tienconlai + ",0000";
            try
            {
                txtTienDV.Text = db.PhieuDichvus.Where(p => p.IDPhieuThue.Equals(id)).First().TongTien.ToString();
            }
            catch
            {
                txtTienDV.Text = "0";
            }
            if (db.PhieuDichvus.Where(p => p.IDPhieuThue.Equals(cbIDThue.SelectedValue.ToString())).Count() > 0)
            {
                cbIDDV.DisplayMember = "ID";
                cbIDDV.ValueMember = "ID";
                cbIDDV.DataSource = db.PhieuDichvus.Where(p => p.IDPhieuThue.Equals(id));
            }
            else
            {
                cbIDDV.Text = "";
            }

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string[] arr1 = txtTienThanhToan.Text.Split(',');
            int tienthue = Convert.ToInt32(arr1[0]);
            string[] arr2 = txtTienDV.Text.Split(',');
            int tiendv = Convert.ToInt32(arr2[0]);
            int tong = Convert.ToInt32( tienthue+tiendv );
            string id = db.PhieuThuePhongs.Where(p => p.ID.Equals(cbIDThue.SelectedValue.ToString())).First().IDPhong;
            Phong edit = db.Phongs.Where(p => p.ID.Equals(id)).SingleOrDefault();
            edit.IDTinhTrang = "1";
            db.SubmitChanges();
            PhieuThuePhong ds = db.PhieuThuePhongs.Where(p => p.ID.Equals(cbIDThue.SelectedValue.ToString())).SingleOrDefault();
            ds.TinhTrang = "Đã thanh toán";
            db.SubmitChanges();

            if (cbIDDV.Text == "")
            {
                db.ThemHoaDon(tong, DateTime.Now.Date, cbIDThue.Text, Cons.Cons.idNhanVien);
            }
            else
            {
                db.InsertHoaDon(tong, DateTime.Now.Date, cbIDThue.Text, Convert.ToInt32(cbIDDV.SelectedValue), Cons.Cons.idNhanVien);
            }

            MessageBox.Show("Thêm thành công");
            dtgvHoaDon.DataSource = db.LoadHoaDon();
            int n = db.PhieuThuePhongs.Where(p => p.TinhTrang.Equals("Đang Thuê")).Count();
            if (n == 0) cbIDThue.Text = "";
            cbIDThue.DisplayMember = "ID";
            cbIDThue.ValueMember = "ID";
            cbIDThue.DataSource = db.PhieuThuePhongs.Where(p => p.TinhTrang.Equals("Đang Thuê"));
            try
            {
                

            }
            catch
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không? ", "Xóa sản phẩm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                try
                {
                    string pt = dtgvHoaDon.CurrentRow.Cells[2].Value.ToString();
                    int dv = Convert.ToInt32(dtgvHoaDon.CurrentRow.Cells[3].Value);
                    db.DeleteHoaDon(Convert.ToInt32(dtgvHoaDon.CurrentRow.Cells[0].Value));
                    db.XoaPDV(dv);
                    db.DeletePhieuThue(pt);
                    MessageBox.Show("Xoá Thành Công");
                    dtgvHoaDon.DataSource = db.LoadHoaDon();
                }
                catch
                {
                    MessageBox.Show("Xoá Thất bại");
                }
            }
        }

        private void dtgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            button1.Enabled = true;
            btXoa.Enabled = true;
        }

        private void cbIDThue_TextChanged(object sender, EventArgs e)
        {
            if (cbIDThue.Text.ToString() == "") btThem.Enabled = false;
            else btThem.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlConnection con = new SqlConnection(@"server=NHUAN;database=QLKS;uid=sa;pwd=system");
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LoadRp";
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(dtgvHoaDon.CurrentRow.Cells[0].Value));
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);
                rpHoaDon rp = new rpHoaDon();
                //rp.SetDataSource(db.LoadRp(Convert.ToInt32(dtgvHoaDon.CurrentRow.Cells[0].Value)));
                rp.SetDataSource(dt);
                Report r = new Report();
                r.crystalReportViewer1.ReportSource = rp;
                r.ShowDialog();
                con.Close();
            }
            catch
            {

            }
            
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            dtgvHoaDon.DataSource = db.TimHoaDon(txtTim.Text);
        }

        private void btThongKe_Click(object sender, EventArgs e)
        {
            dtgvHoaDon.DataSource = db.ThongKeHoaDon(dtpTu.Value, dtpDen.Value);
        }
    }
}
