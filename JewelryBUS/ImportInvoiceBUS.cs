using JewelryDAO;
using JewelryDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryBUS
{
    public class ImportInvoiceBUS
    {
        public List<ImportInvoiceDTO> LayTatCaHoaDon()
        {
            ImportInvoiceDAO IncDAO = new ImportInvoiceDAO();
            return IncDAO.LayDanhSachHoaDon();
        }

    }
}
