using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_HinhChuNhat_Class
{
    internal class HinhChuNhat
    {

        public double ChieuRong;
        public double ChieuCao;

        public double TinhDienTich()
        {
            return ChieuRong * ChieuCao;
        }
        public double TinhChuVi()
        {
            return (ChieuCao + ChieuRong) * 2;
        }
    }
}
