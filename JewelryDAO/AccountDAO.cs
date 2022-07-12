using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JewelryDTO;

namespace JewelryDAO
{
    public class AccountDAO
    {
        public AccountDTO TimTaiKhoan(string username)
        {
            AccountDTO account = null;
            string strTruyVan = "Select * from TaiKhoan where idTaiKhoan = @username and trangThai = 1";
            SqlConnection connect = DataProvider.TaoKetNoi();
            SqlParameter par = new SqlParameter("username", username);
            SqlDataReader sdr = DataProvider.TruyVan(strTruyVan, par, connect);
            while (sdr.Read())
            {
                account = new AccountDTO();
                account.idTaiKhoan = sdr["idTaiKhoan"].ToString();
                account.matKhau = sdr["matKhau"].ToString();
                account.hoTen = sdr["hoTen"].ToString();
                account.chucVu = sdr["chucVu"].ToString();
                account.ngaySinh = DateTime.Parse(sdr["ngaySinh"].ToString()).Date;
                account.gioiTinh = sdr["gioiTinh"].ToString();
                account.diaChi = sdr["diaChi"].ToString();
                account.soDienThoai = sdr["soDienThoai"].ToString();
                
            }
            sdr.Close();
            connect.Close();
            return account;
        }

        public List<AccountDTO> LayDanhSachTaiKhoan()
        {
            List<AccountDTO> ls = new List<AccountDTO>();
            SqlConnection connect = DataProvider.TaoKetNoi();
            string query = "Select * from TaiKhoan";
            SqlDataReader sdr = DataProvider.TruyVan(query, connect);
            while (sdr.Read())
            {
                AccountDTO account = new AccountDTO();
                account.idTaiKhoan = sdr["idTaiKhoan"].ToString();
                account.matKhau = sdr["matKhau"].ToString();
                account.hoTen = sdr["hoTen"].ToString();
                account.chucVu = sdr["chucVu"].ToString();
                account.ngaySinh = DateTime.Parse(sdr["ngaySinh"].ToString()).Date;
                account.gioiTinh = sdr["gioiTinh"].ToString();
                account.diaChi = sdr["diaChi"].ToString();
                account.soDienThoai = sdr["soDienThoai"].ToString();
                ls.Add(account);
            }
            sdr.Close();
            connect.Close();
            return ls;
        }

        public List<AccountDTO> LayDanhSachTaiKhoanTonTai(int i)
        {
            List<AccountDTO> ls = new List<AccountDTO>();
            SqlConnection connect = DataProvider.TaoKetNoi();
            string query = "Select * from TaiKhoan where trangThai=1";
            SqlDataReader sdr = DataProvider.TruyVan(query, connect);
            while (sdr.Read())
            {
                AccountDTO account = new AccountDTO();
                account.idTaiKhoan = sdr["idTaiKhoan"].ToString();
                account.matKhau = sdr["matKhau"].ToString();
                account.hoTen = sdr["hoTen"].ToString();
                account.chucVu = sdr["chucVu"].ToString();
                account.ngaySinh = DateTime.Parse(sdr["ngaySinh"].ToString()).Date;
                account.gioiTinh = sdr["gioiTinh"].ToString();
                account.diaChi = sdr["diaChi"].ToString();
                account.soDienThoai = sdr["soDienThoai"].ToString();
                ls.Add(account);
            }
            sdr.Close();
            connect.Close();
            return ls;
        }
        public bool ThemMotNhanVienMoi(AccountDTO A)
        {
            try
            {
                string insert = "Insert into TaiKhoan values (@idTaiKhoan,@matKhau,@hoTen,@chucVu,@ngaySinh,@gioiTinh,@diaChi,@soDienThoai,1)";
                
                SqlParameter[] pars = new SqlParameter[8];
                pars[0] = new SqlParameter("idTaiKhoan", A.idTaiKhoan);
                pars[1] = new SqlParameter("matKhau", A.matKhau);
                pars[2] = new SqlParameter("hoTen", A.hoTen);
                pars[3] = new SqlParameter("chucVu", A.chucVu);
                pars[4] = new SqlParameter("ngaySinh", A.ngaySinh);
                pars[5] = new SqlParameter("gioiTinh", A.gioiTinh);
                pars[6] = new SqlParameter("diaChi", A.diaChi);
                pars[7] = new SqlParameter("soDienThoai", A.soDienThoai);
                SqlConnection connect = DataProvider.TaoKetNoi();
                bool kq = DataProvider.ThucThi(insert, pars, connect);
                connect.Close();
                return kq;
            }
            catch
            {
                return false;
            }
        }

        public bool CapNhatMotNhanVien(AccountDTO A)
        {
            try
            {
                string update = "Update TaiKhoan set matKhau=@matKhau, hoTen=@hoTen, chucVu=@chucVu, ngaySinh=@ngaySinh, gioiTinh=@gioiTinh, diaChi=@diaChi, soDienThoai=@soDienThoai where idTaiKhoan=@idTaiKhoan";
                SqlParameter[] pars = new SqlParameter[8];
                pars[0] = new SqlParameter("matKhau", A.matKhau);
                pars[1] = new SqlParameter("hoTen", A.hoTen);
                pars[2] = new SqlParameter("chucVu", A.chucVu);
                pars[3] = new SqlParameter("ngaySinh", A.ngaySinh);
                pars[4] = new SqlParameter("gioiTinh", A.gioiTinh);
                pars[5] = new SqlParameter("diaChi", A.diaChi);
                pars[6] = new SqlParameter("soDienThoai", A.soDienThoai);
                pars[7] = new SqlParameter("idTaiKhoan", A.idTaiKhoan);
                SqlConnection connect = DataProvider.TaoKetNoi();
                bool kq = DataProvider.ThucThi(update, pars, connect);
                connect.Close();
                return kq;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaMotTaiKhoan(AccountDTO A)
        {
            try
            {
                string update = "Update TaiKhoan set trangThai=0 where idTaiKhoan=@idTaiKhoan";
                SqlParameter par = new SqlParameter("idTaiKhoan", A.idTaiKhoan);
                SqlConnection connect = DataProvider.TaoKetNoi();
                bool kq = DataProvider.ThucThi(update, par, connect);
                connect.Close();
                return kq;
            }
            catch
            {
                return false;
            }
        }
    }
}
