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
        public bool ThemHoaDonMoi()
        {
            SalesInvoiceDAO sadao = new SalesInvoiceDAO();
            return sadao.ThemMoiMotHoaDon();
        }
        public SalesInvoiceDTO LayHDLonNhat()
        {
            SalesInvoiceDAO dao = new SalesInvoiceDAO();
            return dao.LayMaHDLonNhat();
        }

        public bool CapNhatHDBH(SalesInvoiceDTO SI)
        {
            SalesInvoiceDAO dao = new SalesInvoiceDAO();
            return dao.CapNhatHDBanHang(SI);
        }
    }
}
