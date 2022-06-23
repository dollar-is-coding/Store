using JewelryDAO;
using JewelryDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryBUS
{
    public class SISDIBUS
    {
        public List<SISDIDTO> LayTatCaDanhSachCTHDBanHang()
        {
            SISDIDAO SISD = new SISDIDAO();
            return SISD.LayDanhSachCTHDBanHang();
        }
        public List<SISDIDTO> LayTatCaDanhSachCTHDBanHang(string idHoaDon)
        {
            SISDIDAO SISD = new SISDIDAO();
            return SISD.LayDanhSachCTHDBanHang(idHoaDon);
        }
        public List<SISDIDTO> LayCTSPTuHDBHLonNhat(string idHoaDon)
        {
            SISDIDAO SISDI = new SISDIDAO();
            return SISDI.LayCTSPTheoHDBHLonNhat(idHoaDon);
        }
    }
}
