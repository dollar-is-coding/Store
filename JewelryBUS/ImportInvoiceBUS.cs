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
        public List<ImportInvoiceDTO> LayHoaDonLonNhat()
        {
            ImportInvoiceDAO dao = new ImportInvoiceDAO();
            return dao.LayIDHoaDonLonNhat();
        }
        public bool ThemHDMoi(string idTaiKhoan)
        {
            ImportInvoiceDAO hddao = new ImportInvoiceDAO();
            return hddao.ThemHoaDonNhap(idTaiKhoan);
        }

    }
}
