using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JewelryDTO;
using JewelryDAO;

namespace JewelryBUS
{
    public class ProductDetailBUS
    {
        public List<ProductDetailDTO> LayTatCaPD(string idSanPham)
        {
            ProductDetailDAO PD = new ProductDetailDAO();
            return PD.LayDanhSachKichCo(idSanPham);
        }

        public bool ThemChiTietSanPhamMoi(ProductDetailDTO PD)
        {
            ProductDetailDAO dao = new ProductDetailDAO();
            return dao.ThemMotChiTietSanPhamMoi(PD);
        }
    }
}
