using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryDTO
{
    public class SalesDetailInvoiceDTO
    {
        public string idHoaDon { get; set; }
        public string idSanPham { get; set; }
        public float size { get; set; }
        public int soLuong { get; set; }
        public decimal giaBan { get; set; }
    }
}
