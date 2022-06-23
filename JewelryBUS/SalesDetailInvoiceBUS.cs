using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JewelryDTO;
using JewelryDAO;

namespace JewelryBUS
{
    public class SalesDetailInvoiceBUS
    {
        public List<SalesDetailInvoiceDTO> LayHDBHTheoID(string idHoaDon)
        {
            SalesDetailInvoiceDAO dao = new SalesDetailInvoiceDAO();
            return dao.LayDanhSachCTHDBanTheoID(idHoaDon);
        }

        public bool ThemMotHDBanHangMoi(SalesDetailInvoiceDTO SDI)
        {
            SalesDetailInvoiceDAO dao = new SalesDetailInvoiceDAO();
            return dao.ThemMotChiTietHDBanMoi(SDI);
        }
    }
}
