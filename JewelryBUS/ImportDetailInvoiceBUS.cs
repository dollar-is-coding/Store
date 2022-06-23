using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JewelryDTO;
using JewelryDAO;

namespace JewelryBUS
{
    public class ImportDetailInvoiceBUS
    {
        public bool ThemMotChiTietHoaDonMoi(ImportDetailInvoiceDTO IDI)
        {
            ImportDetailInvoiceDAO dao = new ImportDetailInvoiceDAO();
            return dao.ThemChiTietHoaDonMoi(IDI);
        }
    }
}
