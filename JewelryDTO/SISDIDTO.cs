using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryDTO
{
   public class SISDIDTO
    {
        public string idHoaDon { get; set; }
        public string idCTHD { get; set; }
        public string idKhachHang { get; set; }
        public string hoTen { get; set; }
        public string idTaiKhoan { get; set; }
        public string idSanPham { get; set; }
        public float size { get; set; }
        public decimal giaBan { get; set; }
        public int soLuong { get; set; }
        public DateTime ngayBan { get; set; }
    }
}
