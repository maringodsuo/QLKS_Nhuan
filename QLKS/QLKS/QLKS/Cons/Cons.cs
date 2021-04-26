using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.Cons
{
   
    class Cons
    {
        public static int tienCoc;
        public static DateTime ngayThue;
        public static DateTime ngayDi;
        public static string idKhachHang;
        //public static string tenKhachHang;
        public static string idNhanVien;
        public static string tenNhanVien;
        public static string idPhong;
        public static string tenPhong;
        public static int role;
    }

    public enum Role
    {
        QuanLy = 1,
        TiepTan,
        KeToan
    }
}
