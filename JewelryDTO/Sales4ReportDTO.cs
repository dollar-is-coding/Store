using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryDTO
{
    public class Sales4ReportDTO
    {
        public string idHoaDon { get; set; }
        public string idSanPham { get; set; }
        public string tenSanPham { get; set; }
        public float size { get; set; }
        public int soLuong { get; set; }
        public decimal giaBan { get; set; }
        public string tenDanhMuc { get; set; }
        public string tenKhachHang { get; set; }
        public string tenTaiKhoan { get; set; }
        public string ngayBan { get; set; }
    }
}
