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
    public partial class DoiMatKhau : Form
    {
        CSDLDataContext db = new CSDLDataContext();
        bool ktra = false;
        public DoiMatKhau()
        {
            InitializeComponent();
        }
        void KiemTra()
        {
            if (txtMatKhauNV.Text.Trim() == "")
            {
                errChiTiet.SetError(txtMatKhauNV, "Bạn không để trống!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            string mk = db.NhanViens.Where(p => p.ID == Cons.Cons.idNhanVien).First().Matkhau;
            if (txtMatKhauNV.Text != mk)
            {
                errChiTiet.SetError(txtMatKhauNV, "Mật khẩu không chính xác!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (textBox1.Text.Trim() == "")
            {
                errChiTiet.SetError(textBox1, "Bạn không để trống!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (textBox2.Text.Trim() == "")
            {
                errChiTiet.SetError(textBox2, "Bạn không để trống!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (textBox1.Text != textBox2.Text )
            {
                errChiTiet.SetError(textBox2, "Mật khẩu không trùng nhau!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (String.IsNullOrEmpty(txtMatKhauNV.Text) == true || String.IsNullOrEmpty(textBox1.Text) == true || String.IsNullOrEmpty(textBox2.Text) == true
                || textBox1.Text != textBox2.Text)
                ktra = false;
            else ktra = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KiemTra();
            NhanVien nv = db.NhanViens.Where(p => p.ID == Cons.Cons.idNhanVien).First();
            if(ktra == true)
            {
                nv.Matkhau = textBox2.Text;
                db.SubmitChanges();
                MessageBox.Show("Đổi mật khẩu thành công");
                this.Close();
            }
            
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {

        }
    }
}
