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
            lblName.Visible = false;
            lblUsername.Visible = false;
            lblPass.Visible = false;
            lblPhone.Visible = false;
            lblAddress.Visible = false;
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
            ALs = ABUS.LayTatCaTaiKhoanTonTai(1);
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
                dtpDateofBirth.Text = person.ngaySinh.ToString();
                cboGender.Text = person.gioiTinh;
                txtPhone.Text = person.soDienThoai;
                txtAddress.Text = person.diaChi;
            }
        }

        private void LayThongTinNhanVien()
        {
            person = new AccountDTO();
            person.hoTen = txtStaffName.Text;
            person.idTaiKhoan = txtUserName.Text;
            person.matKhau = txtPassword.Text;
            person.chucVu = cboPosition.Text;
            string[] item = dtpDateofBirth.Text.ToString().Split('/');
            person.ngaySinh = DateTime.Parse(item[2] + "/" + item[1] + "/" + item[0]);
            person.gioiTinh = cboGender.Text;
            person.diaChi = txtAddress.Text;
            person.soDienThoai = txtPhone.Text;
            person.trangThai = 1;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int a = 1;
            for (int i = 0; i < dgvAddStaff.RowCount; i++)
            {
                if (txtUserName.Text == dgvAddStaff.Rows[i].Cells[1].Value.ToString())
                    a++;
            }
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || a != 1)
            {
                lblUsername.Visible = true;
                return;
            }
            else
                lblUsername.Visible = false;
            if (string.IsNullOrWhiteSpace(txtStaffName.Text))
            {
                lblName.Visible = true;
                return;
            }
            else
                lblName.Visible = false;
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                lblPhone.Visible = true;
                return;
            }
            else
                lblPhone.Visible = false;
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblPass.Visible = true;
                return;
            }
            else
                lblPass.Visible = false;
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                lblAddress.Visible = true;
                return;
            }
            else
                lblAddress.Visible = false;

            LayThongTinNhanVien();
            if (ABUS.ThemTKMoi(person))
                MessageBox.Show("Account added!", "Add account", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadTaiKhoan();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            int a = 1;
            for (int i = 0; i < dgvAddStaff.RowCount; i++)
            {
                if (txtUserName.Text == dgvAddStaff.Rows[i].Cells[1].Value.ToString())
                    a++;
            }
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || a == 1)
            {
                lblUsername.Visible = true;
                return;
            }
            else
                lblUsername.Visible = false;
            if (string.IsNullOrWhiteSpace(txtStaffName.Text))
            {
                lblName.Visible = true;
                return;
            }
            else
                lblName.Visible = false;
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                lblPhone.Visible = true;
                return;
            }
            else
                lblPhone.Visible = false;
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblPass.Visible = true;
                return;
            }
            else
                lblPass.Visible = false;
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                lblAddress.Visible = true;
                return;
            }
            else
                lblAddress.Visible = false;

            LayThongTinNhanVien();
            if (ABUS.CapNhatTK(person))
                MessageBox.Show("Account updated!", "Update account", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadTaiKhoan();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int a = 1;
            for (int i = 0; i < dgvAddStaff.RowCount; i++)
            {
                if (txtUserName.Text == dgvAddStaff.Rows[i].Cells[1].Value.ToString())
                    a++;
            }
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || a == 1)
            {
                lblUsername.Visible = true;
                return;
            }
            else
                lblUsername.Visible = false;
            lblName.Visible = false;
            lblPhone.Visible = false;
            lblPass.Visible = false;
            lblAddress.Visible = false;

            LayThongTinNhanVien();
            if (ABUS.XoaTK(person))
                MessageBox.Show("Account deleted!", "Delete account", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadTaiKhoan();
        }

        private void txtStaffName_Click(object sender, EventArgs e)
        {
            txtStaffName.SelectAll();
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            txtUserName.SelectAll();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.SelectAll();
        }

        private void txtPhone_Click(object sender, EventArgs e)
        {
            txtPhone.SelectAll();
        }

        private void txtAddress_Click(object sender, EventArgs e)
        {
            txtAddress.SelectAll();
        }

        private void ucAddStaff_Click(object sender, EventArgs e)
        {
            label1.Focus();
        }

        private void pnlAddCart_Click(object sender, EventArgs e)
        {
            label1.Focus();
        }

        private void ucAddStaff_DoubleClick(object sender, EventArgs e)
        {
            dgvAddStaff.Refresh();
        }

    }
}
