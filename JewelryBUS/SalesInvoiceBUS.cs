using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JewelryDAO;
using JewelryDTO;

namespace JewelryBUS
{
    public class SalesInvoiceBUS
    {
        public List<SalesInvoiceDTO> LayTatCaHDBanHang()
        {
            SalesInvoiceDAO hdDAO = new SalesInvoiceDAO();
            return hdDAO.LayDanhSachHoaDonBanHang();
        }
    }
}
