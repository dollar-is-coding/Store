using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JewelryDTO;
using JewelryDAO;

namespace JewelryBUS
{
    public class Sales4ReportBUS
    {
        public List<Sales4ReportDTO> TatCaHDBTheoThang(int month,int year)
        {
            Sales4ReportDAO S4R = new Sales4ReportDAO();
            return S4R.LayTatCaHDBTheoThang(month, year);
        }

        public List<Sales4ReportDTO> XuatHDBH(string idHoaDon)
        {
            Sales4ReportDAO S4R = new Sales4ReportDAO();
            return S4R.LayHDMoiNhat(idHoaDon);
        }

        public decimal tongTien(string idHoaDon)
        {
            Sales4ReportDAO S4R = new Sales4ReportDAO();
            return S4R.total(idHoaDon);
        }
    }
}
