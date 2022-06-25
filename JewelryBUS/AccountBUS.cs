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

        public List<AccountDTO> LayTatCaTaiKhoanTonTai(int i)
        {
            AccountDAO account = new AccountDAO();
            return account.LayDanhSachTaiKhoanTonTai(i);
        }

        public bool ThemTKMoi(AccountDTO A)
        {
            AccountDAO dao = new AccountDAO();
            return dao.ThemMotNhanVienMoi(A);
        }
        public bool CapNhatTK(AccountDTO A)
        {
            AccountDAO dao = new AccountDAO();
            return dao.CapNhatMotNhanVien(A);
        }

        public bool XoaTK(AccountDTO A)
        {
            AccountDAO dao = new AccountDAO();
            return dao.XoaMotTaiKhoan(A);
        }
    }
}
