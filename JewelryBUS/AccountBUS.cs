using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JewelryDTO;
using JewelryDAO;

namespace JewelryBUS
{
    public class AccountBUS
    {
       public AccountDTO DangNhap(string username)
        {
            AccountDAO account = new AccountDAO();
            return account.TimTaiKhoan(username);
        }

        public List<AccountDTO> LayTatCaTaiKhoan()
        {
            AccountDAO account = new AccountDAO();
            return account.LayDanhSachTaiKhoan();
        }
    }
}
