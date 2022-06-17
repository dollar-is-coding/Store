using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JewelryDAO;
using JewelryDTO;

namespace JewelryBUS
{
    public class CategoryBUS
    {
        public List<CategoryDTO> LayTatCaDanhMuc()
        {
            CategoryDAO category = new CategoryDAO();
            return category.LayDanhSachDanhMuc();
        }
    }
}
