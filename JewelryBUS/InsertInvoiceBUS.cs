using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JewelryDTO;
using JewelryDAO;

namespace JewelryBUS
{
    public class InsertInvoiceBUS
    {
        public List<InsertInvoiceDTO> LayTatCaHoaDonNhap(string idHoaDon)
        {
            InsertInvoiceDAO dao = new InsertInvoiceDAO();
            return dao.LayDanhSachHoaDonNhap(idHoaDon);
        }
    }
}
