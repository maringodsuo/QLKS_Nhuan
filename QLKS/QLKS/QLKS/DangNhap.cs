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
    public partial class DangNhap : Form
    {
        CSDLDataContext db = new CSDLDataContext();
        int role;
        public DangNhap()
        {
            InitializeComponent();

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            try
            {
                role = Convert.ToInt32(db.TimRole(txbUserID.Text, txbPassword.Text).First().Roles);
                Cons.Cons.role = role;
                string nv = db.TimTenNV(txbUserID.Text, txbPassword.Text).First().Ten;
                Cons.Cons.tenNhanVien = nv;

                Cons.Cons.idNhanVien = db.TimTenNV(txbUserID.Text, txbPassword.Text).First().ID;
            }
            catch
            {
                MessageBox.Show("Tên Đăng Nhập hoặc Tài khoản không đúng!");
                ClearTextBox();
                f = null;
                return;
            }
            
            
            switch (role)
            {
                case (int)Cons.Role.QuanLy:
                    f = new QuanLy();
                    break;
                case (int)Cons.Role.TiepTan:
                    f = new QuanLy();
                    break;
                case (int)Cons.Role.KeToan:
                    MessageBox.Show("Ke Toan");
                    //f = new ThongKeBaoCao();
                    break;
                default:
                    break;
            };
            //f.FormClosed += F_FormClosed;
            f.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            f.ShowDialog();
            this.Show();
            ClearTextBox();
        }
        void ClearTextBox()
        {
            txbUserID.Clear();
            txbPassword.Clear();
        }
        private void F_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
