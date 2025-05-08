using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Barcodescanner
{
    internal class DanhSachTaiKhoan
    {
        private static DanhSachTaiKhoan instance;

        internal static DanhSachTaiKhoan Instance 
        { 
            get
            {
                if(instance == null)
                    instance = new DanhSachTaiKhoan();
                return instance;
            }
            set => instance = value; 
        }
        List<TaiKhoan> listTaiKhoan;

        public List<TaiKhoan> ListTaiKhoan 
        { 
            get => listTaiKhoan; 
            set => listTaiKhoan = value; 
        }

        public DanhSachTaiKhoan() 
        {
            listTaiKhoan = new List<TaiKhoan>();
            listTaiKhoan.Add(new TaiKhoan("Nguyễn Tuấn Khoa", "17012003"));
            listTaiKhoan.Add(new TaiKhoan("Nguyễn Đăng Duy", "07071979"));
            listTaiKhoan.Add(new TaiKhoan("1", "1"));
        }
    }
}
