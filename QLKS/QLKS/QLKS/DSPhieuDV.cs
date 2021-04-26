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
    public partial class DSPhieuDV : Form
    {

        public DSPhieuDV()
        {
            InitializeComponent();
        }
        int them = -1;
        int id = 0;
        int tong = 0;
        string ghichu = "";
        CSDLDataContext db = new CSDLDataContext();
        
        private void DSPhieuDV_Load(object sender, EventArgs e)
        {
            lbTenNhanVien.Text = Cons.Cons.tenNhanVien;
            dtgvPhieuDV.DataSource = db.LoadPDV();
            cbIDPhieuThue.DisplayMember = "ID";
            cbIDPhieuThue.ValueMember = "ID";
            cbIDPhieuThue.DataSource = db.PhieuThuePhongs.Where(p => p.TinhTrang.Equals("Đang Thuê"));
            List<string> s = new List<string>();
            s.Add(cbIDPhieuThue.Text);
            cbTenDV.DisplayMember = "Ten";
            cbTenDV.ValueMember = "ID";
            cbTenDV.DataSource = db.LoadDichVu();

            txtTong.Text = "0";
        }

        private void cbIDPhieuThue_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cbIDPhieuThue.SelectedValue.ToString();
            txtTenKH.Text = db.LoadTheoIDThue(id).First().TenKhachHang;
            txtTenP.Text = db.LoadTheoIDThue(id).First().TenPhong;

        }

        private void cbTenDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cbTenDV.SelectedValue.ToString();
            txtGiaDV.Text = db.DichVus.Where(p=>p.ID.Equals(id)).First().Gia.ToString();
            txtSL.Minimum = 1;
            int sl = Convert.ToInt32(txtSL.Value);

            
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            dtgvDichVu.Rows.Add();
            them +=1;
            int sl = Convert.ToInt32(txtSL.Value);
            id += 1;
            dtgvDichVu.Rows[them].Cells[0].Value = id;
            dtgvDichVu.Rows[them].Cells[1].Value = cbTenDV.Text.ToString();
            dtgvDichVu.Rows[them].Cells[2].Value = txtGiaDV.Text.ToString();
            dtgvDichVu.Rows[them].Cells[3].Value = sl;

            string[] arr = txtGiaDV.Text.Split(',');
            int gia = Convert.ToInt32(arr[0]);
            
            tong = tong + gia * sl;
            txtTong.Text = tong + ",0000";
            
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int i = dtgvDichVu.CurrentCell.RowIndex;
                int sl = Convert.ToInt32(dtgvDichVu.Rows[i].Cells[3].Value);
                string[] arr = dtgvDichVu.Rows[i].Cells[2].Value.ToString().Split(',');
                int gia = Convert.ToInt32(arr[0]);
                int tru = sl * gia;

                tong = tong - tru;
                txtTong.Text = tong + ",0000";

                
                dtgvDichVu.Rows.RemoveAt(i);
                them = them - 1;
            }
            catch
            {

            }
        }

        private void btInHD_Click(object sender, EventArgs e)
        {
        try
            {
                int dong = dtgvDichVu.Rows.Count;
                dong = dong - 2;
                for(int i=0; i<=dong;i++)
                {
                    string ten = dtgvDichVu.Rows[i].Cells[1].Value.ToString();
                    int sl = Convert.ToInt32(dtgvDichVu.Rows[i].Cells[3].Value);
                    string[] arr = dtgvDichVu.Rows[i].Cells[2].Value.ToString().Split(',');
                    int gia = Convert.ToInt32(arr[0]);
                    ghichu = ghichu + sl + "x" + ten + " ";
                }
                
                int dem = db.PhieuDichvus.Where(p => p.IDPhieuThue.Equals(cbIDPhieuThue.SelectedValue.ToString())).Count();
                if (dem > 0) MessageBox.Show("Phiếu thuê đã sử dụng dịch vụ");
                else
                {
                    db.InsertPDV(tong, DateTime.Now.Date, ghichu, cbIDPhieuThue.Text, Cons.Cons.idNhanVien);
                    MessageBox.Show("Thêm Thành Công");
                    dtgvPhieuDV.DataSource = db.LoadPDV();
                    ghichu = "";
                    dtgvDichVu.Rows.Clear();
                    them = -1;

                    int n = db.PhieuThuePhongs.Where(p => p.TinhTrang.Equals("Đang Thuê")).Count();
                    if (n == 0) cbIDPhieuThue.Text = "";

                    cbIDPhieuThue.DisplayMember = "ID";
                    cbIDPhieuThue.ValueMember = "ID";
                    cbIDPhieuThue.DataSource = db.PhieuThuePhongs.Where(p => p.TinhTrang.Equals("Đang Thuê"));
                }

            }
            catch
            {
                MessageBox.Show("Thêm Thất bại!");
            }
        }

        private void btXoaHD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không? ", "Xóa sản phẩm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                try
                {
                    int id = Convert.ToInt32(dtgvPhieuDV.CurrentRow.Cells[0].Value);
                    string pt = dtgvPhieuDV.CurrentRow.Cells[1].Value.ToString();
                    int dem = db.HoaDons.Where(p => p.IDDichVu.Equals(id)).Count();
                    if (dem > 0)
                    {
                        int a = db.HoaDons.Where(p => p.IDDichVu.Equals(id)).First().ID;
                        db.DeleteHoaDon(a);
                        db.XoaPDV(id);
                        db.DeletePhieuThue(pt);
                        MessageBox.Show("Xoá Thành Công");
                        dtgvPhieuDV.DataSource = db.LoadPDV();
                    }
                }
                catch
                {
                    MessageBox.Show("Xoá Thất bại");
                }
            }
        }

        private void dtgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTong_TextChanged(object sender, EventArgs e)
        {
            string[] arr = txtTong.Text.Split(',');
            int s = Convert.ToInt32(arr[0]);
            if (s == 0) btInHD.Enabled = false;
            else btInHD.Enabled = true;
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            DSHoaDon f = new DSHoaDon();
            f.ShowDialog();
            this.Close();
        }
    }
}
