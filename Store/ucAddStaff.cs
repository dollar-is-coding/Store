using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JewelryDTO;
using JewelryBUS;

namespace Jewelry
{
    public partial class ucAddStaff : UserControl
    {
        List<AccountDTO> ALs;
        AccountBUS ABUS = new AccountBUS();
        AccountDTO person;
        public ucAddStaff()
        {
            InitializeComponent();
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btn_MouseEnter(btnAdd);
        }

        private void btn_MouseEnter(Button a)
        {
            a.BackColor = Color.FromArgb(255, 1, 243);
            a.ForeColor = Color.Black;
            a.FlatAppearance.BorderColor = Color.FromArgb(30, 30, 30);
        }

        private void btnRemove_MouseEnter(object sender, EventArgs e)
        {
            btn_MouseEnter(btnRemove);
        }
        private void btn_MouseLeave(Button a)
        {
            a.BackColor = Color.Transparent;
            a.ForeColor = Color.FromArgb(255, 1, 243);
            a.FlatAppearance.BorderColor = Color.FromArgb(255, 1, 243);
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btn_MouseLeave(btnAdd);
        }

        private void btnRemove_MouseLeave(object sender, EventArgs e)
        {
            btn_MouseLeave(btnRemove);
        }

        private void ucAddStaff_Load(object sender, EventArgs e)
        {
            cboPosition.Text = "Staff";
            cboPosition.Items.Add("Staff");
            cboPosition.Items.Add("Manager");
            cboGender.Text = "Male";
            cboGender.Items.Add("Male");
            cboGender.Items.Add("Female");
            dgvAddStaff.AutoGenerateColumns = false;
            LoadTaiKhoan();
        }

        private void LoadTaiKhoan()
        {
            ALs = ABUS.LayTatCaTaiKhoan();
            dgvAddStaff.DataSource = ALs;
        }

        private void btnEdit_MouseEnter(object sender, EventArgs e)
        {
            btn_MouseEnter(btnEdit);
        }

        private void btnEdit_MouseLeave(object sender, EventArgs e)
        {
            btn_MouseLeave(btnEdit);
        }

        private void dgvAddStaff_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAddStaff.SelectedRows.Count > 0)
            {
                person = (AccountDTO)dgvAddStaff.SelectedRows[0].DataBoundItem;
            }
            else
            {
                person = null;
            }
            BindingPerson();
        }

        private void BindingPerson()
        {
            if (person != null)
            {
                txtStaffName.Text = person.hoTen;
                txtUserName.Text = person.idTaiKhoan;
                txtPassword.Text = person.matKhau;
                cboPosition.Text = person.chucVu;
                dtpDateofBirth.Value = person.ngaySinh;
                cboGender.Text = person.gioiTinh;
                txtPhone.Text = person.soDienThoai;
                txtAddress.Text = person.diaChi;
            }
        }
    }
}
