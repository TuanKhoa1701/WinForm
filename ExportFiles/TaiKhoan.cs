using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcodescanner
{
    public class TaiKhoan
    {
        private string tenTaiKhoan;

        public string TenTaiKhoan 
        { 
            get => tenTaiKhoan; 
            set => tenTaiKhoan = value; 
        }

        private string MatKhau;
        public string MatKhau1
        { 
            get => MatKhau; 
            set => MatKhau = value; 
        }
        public TaiKhoan(string tenTaiKhoan,string matKhau)
        {
            this.TenTaiKhoan = tenTaiKhoan;
            this.MatKhau = matKhau;
        }
    }
}
