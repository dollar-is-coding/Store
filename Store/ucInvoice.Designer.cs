
namespace Jewelry
{
    partial class ucInvoice
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSalesInvoice = new System.Windows.Forms.DataGridView();
            this.colInvoiceIDSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStaffSale = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colProductSale = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colSizeSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriceSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantitySale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radSales = new System.Windows.Forms.RadioButton();
            this.radImport = new System.Windows.Forms.RadioButton();
            this.dgvImportInvoice = new System.Windows.Forms.DataGridView();
            this.colInvoiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStaffImport = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colProductImport = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colSizeImport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantityImport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImportPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateImport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSalesInvoice
            // 
            this.dgvSalesInvoice.AllowUserToAddRows = false;
            this.dgvSalesInvoice.AllowUserToResizeRows = false;
            this.dgvSalesInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSalesInvoice.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.dgvSalesInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalesInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalesInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInvoiceIDSale,
            this.colCustomer,
            this.colStaffSale,
            this.colProductSale,
            this.colSizeSale,
            this.colPriceSale,
            this.colQuantitySale,
            this.colDateSale});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalesInvoice.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSalesInvoice.Location = new System.Drawing.Point(50, 100);
            this.dgvSalesInvoice.MultiSelect = false;
            this.dgvSalesInvoice.Name = "dgvSalesInvoice";
            this.dgvSalesInvoice.ReadOnly = true;
            this.dgvSalesInvoice.RowHeadersVisible = false;
            this.dgvSalesInvoice.RowHeadersWidth = 51;
            this.dgvSalesInvoice.RowTemplate.Height = 24;
            this.dgvSalesInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalesInvoice.Size = new System.Drawing.Size(1100, 550);
            this.dgvSalesInvoice.TabIndex = 6;
            // 
            // colInvoiceIDSale
            // 
            this.colInvoiceIDSale.DataPropertyName = "idHoaDon";
            this.colInvoiceIDSale.HeaderText = "Invoice";
            this.colInvoiceIDSale.MinimumWidth = 6;
            this.colInvoiceIDSale.Name = "colInvoiceIDSale";
            this.colInvoiceIDSale.ReadOnly = true;
            this.colInvoiceIDSale.Width = 87;
            // 
            // colCustomer
            // 
            this.colCustomer.DataPropertyName = "hoTen";
            this.colCustomer.HeaderText = "Customer";
            this.colCustomer.MinimumWidth = 6;
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.ReadOnly = true;
            this.colCustomer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCustomer.Width = 102;
            // 
            // colStaffSale
            // 
            this.colStaffSale.DataPropertyName = "idTaiKhoan";
            this.colStaffSale.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colStaffSale.HeaderText = "Staff";
            this.colStaffSale.MinimumWidth = 6;
            this.colStaffSale.Name = "colStaffSale";
            this.colStaffSale.ReadOnly = true;
            this.colStaffSale.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colStaffSale.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colStaffSale.Width = 65;
            // 
            // colProductSale
            // 
            this.colProductSale.DataPropertyName = "idSanPham";
            this.colProductSale.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colProductSale.HeaderText = "Product";
            this.colProductSale.MinimumWidth = 6;
            this.colProductSale.Name = "colProductSale";
            this.colProductSale.ReadOnly = true;
            this.colProductSale.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colProductSale.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colProductSale.Width = 88;
            // 
            // colSizeSale
            // 
            this.colSizeSale.DataPropertyName = "size";
            this.colSizeSale.HeaderText = "Size";
            this.colSizeSale.MinimumWidth = 6;
            this.colSizeSale.Name = "colSizeSale";
            this.colSizeSale.ReadOnly = true;
            this.colSizeSale.Width = 63;
            // 
            // colPriceSale
            // 
            this.colPriceSale.DataPropertyName = "giaBan";
            this.colPriceSale.HeaderText = "Price";
            this.colPriceSale.MinimumWidth = 6;
            this.colPriceSale.Name = "colPriceSale";
            this.colPriceSale.ReadOnly = true;
            this.colPriceSale.Width = 71;
            // 
            // colQuantitySale
            // 
            this.colQuantitySale.DataPropertyName = "soLuong";
            this.colQuantitySale.HeaderText = "Quantity";
            this.colQuantitySale.MinimumWidth = 6;
            this.colQuantitySale.Name = "colQuantitySale";
            this.colQuantitySale.ReadOnly = true;
            this.colQuantitySale.Width = 93;
            // 
            // colDateSale
            // 
            this.colDateSale.DataPropertyName = "ngayBan";
            this.colDateSale.HeaderText = "Date";
            this.colDateSale.MinimumWidth = 6;
            this.colDateSale.Name = "colDateSale";
            this.colDateSale.ReadOnly = true;
            this.colDateSale.Width = 69;
            // 
            // radSales
            // 
            this.radSales.AutoSize = true;
            this.radSales.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSales.ForeColor = System.Drawing.Color.White;
            this.radSales.Location = new System.Drawing.Point(50, 40);
            this.radSales.Name = "radSales";
            this.radSales.Size = new System.Drawing.Size(140, 25);
            this.radSales.TabIndex = 8;
            this.radSales.TabStop = true;
            this.radSales.Text = "Sales-Invoice";
            this.radSales.UseVisualStyleBackColor = true;
            this.radSales.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // radImport
            // 
            this.radImport.AutoSize = true;
            this.radImport.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radImport.ForeColor = System.Drawing.Color.White;
            this.radImport.Location = new System.Drawing.Point(234, 40);
            this.radImport.Name = "radImport";
            this.radImport.Size = new System.Drawing.Size(154, 25);
            this.radImport.TabIndex = 8;
            this.radImport.TabStop = true;
            this.radImport.Text = "Import-Invoice";
            this.radImport.UseVisualStyleBackColor = true;
            this.radImport.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // dgvImportInvoice
            // 
            this.dgvImportInvoice.AllowUserToAddRows = false;
            this.dgvImportInvoice.AllowUserToResizeRows = false;
            this.dgvImportInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvImportInvoice.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.dgvImportInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImportInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvImportInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImportInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInvoiceID,
            this.colStaffImport,
            this.colProductImport,
            this.colSizeImport,
            this.colQuantityImport,
            this.colImportPrice,
            this.colDateImport});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvImportInvoice.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvImportInvoice.Location = new System.Drawing.Point(50, 100);
            this.dgvImportInvoice.MultiSelect = false;
            this.dgvImportInvoice.Name = "dgvImportInvoice";
            this.dgvImportInvoice.ReadOnly = true;
            this.dgvImportInvoice.RowHeadersVisible = false;
            this.dgvImportInvoice.RowHeadersWidth = 51;
            this.dgvImportInvoice.RowTemplate.Height = 24;
            this.dgvImportInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImportInvoice.Size = new System.Drawing.Size(1100, 550);
            this.dgvImportInvoice.TabIndex = 10;
            // 
            // colInvoiceID
            // 
            this.colInvoiceID.DataPropertyName = "idHoaDon";
            this.colInvoiceID.HeaderText = "Invoice";
            this.colInvoiceID.MinimumWidth = 6;
            this.colInvoiceID.Name = "colInvoiceID";
            this.colInvoiceID.ReadOnly = true;
            this.colInvoiceID.Width = 87;
            // 
            // colStaffImport
            // 
            this.colStaffImport.DataPropertyName = "idTaiKhoan";
            this.colStaffImport.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colStaffImport.HeaderText = "Staff";
            this.colStaffImport.MinimumWidth = 6;
            this.colStaffImport.Name = "colStaffImport";
            this.colStaffImport.ReadOnly = true;
            this.colStaffImport.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colStaffImport.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colStaffImport.Width = 65;
            // 
            // colProductImport
            // 
            this.colProductImport.DataPropertyName = "idSanPham";
            this.colProductImport.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colProductImport.HeaderText = "Product";
            this.colProductImport.MinimumWidth = 6;
            this.colProductImport.Name = "colProductImport";
            this.colProductImport.ReadOnly = true;
            this.colProductImport.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colProductImport.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colProductImport.Width = 88;
            // 
            // colSizeImport
            // 
            this.colSizeImport.DataPropertyName = "size";
            this.colSizeImport.HeaderText = "Size";
            this.colSizeImport.MinimumWidth = 6;
            this.colSizeImport.Name = "colSizeImport";
            this.colSizeImport.ReadOnly = true;
            this.colSizeImport.Width = 63;
            // 
            // colQuantityImport
            // 
            this.colQuantityImport.DataPropertyName = "soLuong";
            this.colQuantityImport.HeaderText = "Quantity";
            this.colQuantityImport.MinimumWidth = 6;
            this.colQuantityImport.Name = "colQuantityImport";
            this.colQuantityImport.ReadOnly = true;
            this.colQuantityImport.Width = 93;
            // 
            // colImportPrice
            // 
            this.colImportPrice.DataPropertyName = "giaNhap";
            this.colImportPrice.HeaderText = "Price";
            this.colImportPrice.MinimumWidth = 6;
            this.colImportPrice.Name = "colImportPrice";
            this.colImportPrice.ReadOnly = true;
            this.colImportPrice.Width = 71;
            // 
            // colDateImport
            // 
            this.colDateImport.DataPropertyName = "ngayNhap";
            this.colDateImport.HeaderText = "Date";
            this.colDateImport.MinimumWidth = 6;
            this.colDateImport.Name = "colDateImport";
            this.colDateImport.ReadOnly = true;
            this.colDateImport.Width = 69;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(126)))), ((int)(((byte)(120)))));
            this.txtSearch.Location = new System.Drawing.Point(880, 39);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(230, 28);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.Text = "Search invoice ID...";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::Jewelry.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(1116, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(34, 30);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // ucInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.radSales);
            this.Controls.Add(this.radImport);
            this.Controls.Add(this.dgvImportInvoice);
            this.Controls.Add(this.dgvSalesInvoice);
            this.Name = "ucInvoice";
            this.Size = new System.Drawing.Size(1200, 700);
            this.Load += new System.EventHandler(this.ucReport_Load);
            this.Click += new System.EventHandler(this.ucInvoice_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportInvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSalesInvoice;
        private System.Windows.Forms.RadioButton radSales;
        private System.Windows.Forms.RadioButton radImport;
        private System.Windows.Forms.DataGridView dgvImportInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceIDSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomer;
        private System.Windows.Forms.DataGridViewComboBoxColumn colStaffSale;
        private System.Windows.Forms.DataGridViewComboBoxColumn colProductSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSizeSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriceSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantitySale;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceID;
        private System.Windows.Forms.DataGridViewComboBoxColumn colStaffImport;
        private System.Windows.Forms.DataGridViewComboBoxColumn colProductImport;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSizeImport;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantityImport;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImportPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateImport;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}
