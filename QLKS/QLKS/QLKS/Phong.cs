using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS
{
    class Phongs
    {
        
        public string ID { get => iD; set => iD = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public int SoGiuong { get => soGiuong; set => soGiuong = value; }
        public int SoNguoi { get => soNguoi; set => soNguoi = value; }
        public string LoaiPhong { get => loaiPhong; set => loaiPhong = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public int Gia { get => gia; set => gia = value; }

        private string iD;
        private string tenPhong;
        private int soGiuong;
        private int soNguoi;
        private string loaiPhong;
        private int gia;
        private string tinhTrang;

        public Phongs(string id, string tenPhong, int soGiuong, int soNguoi, string loaiPhong, int gia, string tinhTrang)
        {
            this.ID = id;
            this.TenPhong = tenPhong;
            this.SoGiuong = soGiuong;
            this.SoGiuong = soNguoi;
            this.LoaiPhong = loaiPhong;
            this.Gia = gia;
            this.TinhTrang = tinhTrang;

        }

    }
}
