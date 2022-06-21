using JewelryDAO;
using JewelryDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryBUS
{
    public class IIIDIBUS
    {
        public List<IIIDIDTO> LayTatCaDanhSachCTHoaDonNhapHang()
        {
            IIIDIDAO IDID = new IIIDIDAO();
            return IDID.LayDanhSachCTHoaDonNhapHang();
        }
        public List<IIIDIDTO> LayTatCaDanhSachCTHoaDonNhapHang(string idHoaDon)
        {
            IIIDIDAO IDID = new IIIDIDAO();
            return IDID.LayDanhSachCTHoaDonNhapHang(idHoaDon);
        }
    }
}
