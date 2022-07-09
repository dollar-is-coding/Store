using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JewelryDTO;
using JewelryDAO;

namespace JewelryBUS
{
    public class Import4ReportBUS
    {
        public List<Import4ReportDTO> TatCaHDNTheoThang(int month,int year)
        {
            Import4ReportDAO dao = new Import4ReportDAO();
            return dao.LayHDTheoThang(month, year);
        }
    }
}
