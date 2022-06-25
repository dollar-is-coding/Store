using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JewelryBUS;
using JewelryDTO;

namespace Jewelry
{
    public partial class ucCart : UserControl
    {
        SalesInvoiceBUS SIBUS=new SalesInvoiceBUS();
        SalesDetailInvoiceBUS SDIBUS = new SalesDetailInvoiceBUS();
        SISDIBUS BUS = new SISDIBUS();

        List<SalesDetailInvoiceDTO> SDILs;
        List<SISDIDTO> SISDILs;
        List<ProductDTO> PLs;
        ProductBUS PBUS = new ProductBUS();
        CustomerDTO customer;
        CustomerBUS CBUS = new CustomerBUS();
        SalesInvoiceDTO SI;

        public ucCart()
        {
            InitializeComponent();
        }

        private void btThanhToan_MouseEnter(object sender, EventArgs e)
        {
            btn_MouseEnter(btnThanhToan);
        }

        private void btn_MouseEnter(Button a)
        {
            a.BackColor = Color.FromArgb(255, 1, 243);
            a.ForeColor = Color.Black;
            a.FlatAppearance.BorderColor = Color.FromArgb(30, 30, 30);
        }

        private void btnThanhToan_MouseLeave(object sender, EventArgs e)
        {
            btn_MouseLeave(btnThanhToan);
        }

        private void btn_MouseLeave(Button a)
        {
            a.BackColor = Color.Transparent;
            a.ForeColor = Color.FromArgb(255, 1, 243);
            a.FlatAppearance.BorderColor = Color.FromArgb(255, 1, 243);
        }

        private void ucCart_Load(object sender, EventArgs e)
        {
            lblInvalidName.Visible = lblPhone.Visible = false;
            lblDate.Text = DateTime.Today.ToShortDateString();
            lblStaffName.Text = frmLogIn.staff;
            LoadTenSanPham();
            LoadDGV();
            lblTotal.Text = string.Format("{0:0,0 vnđ}", LoadTotal()).ToString();
        }

        private decimal LoadTotal()
        {
            int x = dgvCart.RowCount;
            decimal total = 0;
            for (int i = 0; i < x; i++)
            {
                total += decimal.Parse(dgvCart.Rows[i].Cells[3].Value.ToString()) * decimal.Parse(dgvCart.Rows[i].Cells[4].Value.ToString());
            }
            return total;
        }

        private void LoadDGV()
        {
            dgvCart.AutoGenerateColumns = false;
            SISDILs = BUS.LayCTSPTuHDBHLonNhat(SIBUS.LayHDLonNhat().idHoaDon.ToString());
            dgvCart.DataSource = SISDILs;
        }
        private void LayThongTinKhachHang()
        {
            customer = new CustomerDTO();
            customer.hoTen = txtCustomer.Text;
            customer.soDienThoai = txtPhone.Text;
        }
        private void LayThongTinHD()
        {
            
            SI = new SalesInvoiceDTO();
            SI.idHoaDon = SIBUS.LayHDLonNhat().idHoaDon.ToString();
            SI.idTaiKhoan = frmLogIn.id.ToString();
            SI.idKhachHang = CBUS.LayIDKhachHang(txtCustomer.Text, txtPhone.Text).idKhachHang.ToString();
            string[] item = lblDate.Text.ToString().Split('/');
            SI.ngayBan = item[2] + "/" + item[1] + "/" + item[0];
        }

        private void LoadTenSanPham()
        {
            PLs = PBUS.LayDanhSachSanPham();
            colProduct.DataSource = PLs;
            colProduct.ValueMember = "idSanPham";
            colProduct.DisplayMember = "tenSanPham";
        }
        private void txtCustomer_Click(object sender, EventArgs e)
        {
            txtCustomer.SelectAll();
        }

        private void txtPhone_Click(object sender, EventArgs e)
        {
            txtPhone.SelectAll();
        }

        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {
            txtCustomer.ForeColor = Color.Black;
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            txtPhone.ForeColor = Color.Black;
        }

        private void ucCart_Click(object sender, EventArgs e)
        {
            lblStaffName.Focus();
        }

        private void pnlCart_Click(object sender, EventArgs e)
        {
            lblStaffName.Focus();
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dgvCart.RowCount > 0)
            {
                if (string.IsNullOrWhiteSpace(txtCustomer.Text) || txtCustomer.Text == "Customer Name")
                {
                    lblInvalidName.Visible = true;
                    return;
                }
                else if (!string.IsNullOrWhiteSpace(txtCustomer.Text) && txtCustomer.Text != "Customer Name")
                    lblInvalidName.Visible = false;
                if (string.IsNullOrWhiteSpace(txtPhone.Text) || txtPhone.Text == "Phone Number")
                {
                    lblPhone.Visible = true;
                    return;
                }
                else if (!string.IsNullOrWhiteSpace(txtPhone.Text) && txtPhone.Text != "Phone Number")
                    lblPhone.Visible = false;
                LayThongTinKhachHang();
                CBUS.ThemKhachHangMoi(customer);
                LayThongTinHD();
                if (SIBUS.CapNhatHDBH(SI))
                {
                    MessageBox.Show("New invoice is created !", "Create invoice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                SIBUS.ThemHoaDonMoi();
                LoadTenSanPham();
                LoadDGV();
            }
            else
                MessageBox.Show("There is nothing in your cart !", "Create invoice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void picReload_Click(object sender, EventArgs e)
        {
            txtCustomer.Text = "Customer Name";
            txtCustomer.ForeColor = Color.FromArgb(128, 126, 120);
            txtPhone.Text = "Phone Number";
            txtPhone.ForeColor=Color.FromArgb(128, 126, 120);
            LoadTenSanPham();
            LoadDGV();
            lblTotal.Text = string.Format("{0:0,0 vnđ}", LoadTotal()).ToString();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
        }
    }
}
