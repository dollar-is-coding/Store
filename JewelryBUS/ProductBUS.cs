using JewelryDAO;
using JewelryDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryBUS
{
   public class ProductBUS
    {
        public List<ProductDTO> LayDanhSachSanPham()
        {
            ProductDAO spDAO = new ProductDAO();
            return spDAO.LayDanhSachSanPham();
        }
    }
}
