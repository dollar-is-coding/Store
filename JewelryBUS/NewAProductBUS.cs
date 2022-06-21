using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JewelryDAO;
using JewelryDTO;

namespace JewelryBUS
{
    public class NewAProductBUS
    {
        public List<NewAProductDTO> LayTatCaThemSanPham()
        {
            NewAProductDAO aNew = new NewAProductDAO();
            return aNew.LayDanhSachThemSanPham();
        }
    }
}
