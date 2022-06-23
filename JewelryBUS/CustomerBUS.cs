using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JewelryDTO;
using JewelryDAO;

namespace JewelryBUS
{
    public class CustomerBUS
    {
        public List<CustomerDTO> LayTatCaKhachHang()
        {
            CustomerDAO customer = new CustomerDAO();
            return customer.LayDanhSachKhachHang();
        }
        public bool ThemKhachHangMoi(CustomerDTO KH)
        {
            CustomerDAO cusdao = new CustomerDAO();
            return cusdao.ThemMotKhachHang(KH);
        }
        public CustomerDTO LayIDKhachHang(string hoTen,string soDienThoai)
        {
            CustomerDAO dao = new CustomerDAO();
            return dao.LayIDKhachHang(hoTen, soDienThoai);
        }
    }
}
