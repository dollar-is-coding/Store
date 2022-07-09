using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JewelryDTO;
using JewelryDAO;

namespace JewelryBUS
{
    public class Product4ReportBUS
    {
        public List<Product4ReportDTO> LayTatCaCTSP()
        {
            Product4ReportDAO dao = new Product4ReportDAO();
            return dao.LayDanhSachChiTietSanPham();
        }
        public List<Product4ReportDTO> LayTatCaCTSP(string tenDanhMuc)
        {
            Product4ReportDAO dao = new Product4ReportDAO();
            return dao.LayDanhSachChiTietSanPham(tenDanhMuc);
        }
    }
}
