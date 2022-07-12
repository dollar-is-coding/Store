using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryDTO
{
    public class Product4ReportDTO
    {
        public string idSanPham { get; set; }
        public string tenSanPham { get; set; }
        public string tenDanhMuc { get; set; }
        public string idDanhMuc { get; set; }
        public float size { get; set; }
        public decimal giaBan { get; set; }
        public int soLuong { get; set; }
    }
}
