using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JewelryDTO;
using JewelryDAO;

namespace JewelryBUS
{
    public class PPDBUS
    {
        public List<PPDDTO> LayTatCaChiTietSanPham()
        {
            PPDDAO PPD = new PPDDAO();
            return PPD.LayDanhSachChiTietSanPham();
        }
        public List<PPDDTO> LayTatCaChiTietSanPham(string idDanhMuc)
        {
            PPDDAO PPD = new PPDDAO();
            return PPD.LayDanhSachChiTietSanPham(idDanhMuc);
        }

        public List<PPDDTO> TimKiem(string idSanPham)
        {
            PPDDAO PPD = new PPDDAO();
            return PPD.LaySanPhamTheoID(idSanPham);
        }
    }
}
