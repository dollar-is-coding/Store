using JewelryBUS;
using JewelryDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jewelry
{
    public partial class ucSearch : UserControl
    {
        public ucSearch()
        {
            InitializeComponent();
        }

        private void btnAddToCart_MouseEnter(object sender, EventArgs e)
        {
            btnAddToCart.BackColor = Color.FromArgb(255, 1, 243);
            btnAddToCart.ForeColor = Color.Black;
            btnAddToCart.FlatAppearance.BorderColor = Color.FromArgb(30, 30, 30);
        }

        private void btnAddToCart_MouseLeave(object sender, EventArgs e)
        {
            btnAddToCart.BackColor = Color.Transparent;
            btnAddToCart.ForeColor = Color.FromArgb(255, 1, 243);
            btnAddToCart.FlatAppearance.BorderColor = Color.FromArgb(255, 1, 243);
        }

        private void ucSearch_Load(object sender, EventArgs e)
        {
           
            LoadDanhMuc();
        }

        private void LoadDanhMuc()
        {
            CategoryBUS category = new CategoryBUS();
            List<CategoryDTO> categoryLs = category.LayTatCaDanhMuc();
            cboSearch.DataSource = categoryLs;
            cboSearch.DisplayMember = "tenDanhMuc";
            cboSearch.ValueMember = "idDanhMuc";
        }
    }
}
