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
    }
}
