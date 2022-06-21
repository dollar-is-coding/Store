
namespace Jewelry
{
    partial class ucReport
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
            this.colInvoiceDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomer = new System.Windows.Forms.DataGridViewComboBoxColumn();
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
            this.colInvoiceDetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStaffImport = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colProductImport = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colSizeImport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantityImport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImportPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateImport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radAll = new System.Windows.Forms.RadioButton();
            this.radChoose = new System.Windows.Forms.RadioButton();
            this.cboReport = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportInvoice)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSalesInvoice
            // 
            this.dgvSalesInvoice.AllowUserToAddRows = false;
            this.dgvSalesInvoice.AllowUserToResizeRows = false;
            this.dgvSalesInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
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
            this.colInvoiceDetail,
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
            // colInvoiceDetail
            // 
            this.colInvoiceDetail.DataPropertyName = "idCTHD";
            this.colInvoiceDetail.HeaderText = "Invoice Detail";
            this.colInvoiceDetail.MinimumWidth = 6;
            this.colInvoiceDetail.Name = "colInvoiceDetail";
            this.colInvoiceDetail.ReadOnly = true;
            this.colInvoiceDetail.Width = 120;
            // 
            // colCustomer
            // 
            this.colCustomer.DataPropertyName = "idKhachHang";
            this.colCustomer.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colCustomer.HeaderText = "Customer";
            this.colCustomer.MinimumWidth = 6;
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.ReadOnly = true;
            this.colCustomer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCustomer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.radSales.Location = new System.Drawing.Point(3, 3);
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
            this.radImport.Location = new System.Drawing.Point(176, 3);
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
            this.dgvImportInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
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
            this.colInvoiceDetailID,
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
            // colInvoiceDetailID
            // 
            this.colInvoiceDetailID.DataPropertyName = "idCTHD";
            this.colInvoiceDetailID.HeaderText = "Invoice Detail";
            this.colInvoiceDetailID.MinimumWidth = 6;
            this.colInvoiceDetailID.Name = "colInvoiceDetailID";
            this.colInvoiceDetailID.ReadOnly = true;
            this.colInvoiceDetailID.Width = 120;
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
            // radAll
            // 
            this.radAll.AutoSize = true;
            this.radAll.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAll.ForeColor = System.Drawing.Color.White;
            this.radAll.Location = new System.Drawing.Point(166, 5);
            this.radAll.Name = "radAll";
            this.radAll.Size = new System.Drawing.Size(60, 25);
            this.radAll.TabIndex = 10;
            this.radAll.TabStop = true;
            this.radAll.Text = "ALL";
            this.radAll.UseVisualStyleBackColor = true;
            this.radAll.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // radChoose
            // 
            this.radChoose.AutoSize = true;
            this.radChoose.Location = new System.Drawing.Point(261, 10);
            this.radChoose.Name = "radChoose";
            this.radChoose.Size = new System.Drawing.Size(17, 16);
            this.radChoose.TabIndex = 11;
            this.radChoose.TabStop = true;
            this.radChoose.UseVisualStyleBackColor = true;
            this.radChoose.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // cboReport
            // 
            this.cboReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReport.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboReport.FormattingEnabled = true;
            this.cboReport.Location = new System.Drawing.Point(289, 4);
            this.cboReport.Name = "cboReport";
            this.cboReport.Size = new System.Drawing.Size(200, 29);
            this.cboReport.TabIndex = 9;
            this.cboReport.SelectedValueChanged += new System.EventHandler(this.cboReport_SelectedValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radImport);
            this.panel1.Controls.Add(this.radSales);
            this.panel1.Location = new System.Drawing.Point(50, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 50);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboReport);
            this.panel2.Controls.Add(this.radAll);
            this.panel2.Controls.Add(this.radChoose);
            this.panel2.Location = new System.Drawing.Point(658, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 50);
            this.panel2.TabIndex = 13;
            // 
            // ucReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvImportInvoice);
            this.Controls.Add(this.dgvSalesInvoice);
            this.Name = "ucReport";
            this.Size = new System.Drawing.Size(1200, 700);
            this.Load += new System.EventHandler(this.ucReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportInvoice)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSalesInvoice;
        private System.Windows.Forms.RadioButton radSales;
        private System.Windows.Forms.RadioButton radImport;
        private System.Windows.Forms.DataGridView dgvImportInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceIDSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceDetail;
        private System.Windows.Forms.DataGridViewComboBoxColumn colCustomer;
        private System.Windows.Forms.DataGridViewComboBoxColumn colStaffSale;
        private System.Windows.Forms.DataGridViewComboBoxColumn colProductSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSizeSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriceSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantitySale;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceDetailID;
        private System.Windows.Forms.DataGridViewComboBoxColumn colStaffImport;
        private System.Windows.Forms.DataGridViewComboBoxColumn colProductImport;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSizeImport;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantityImport;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImportPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateImport;
        private System.Windows.Forms.RadioButton radAll;
        private System.Windows.Forms.RadioButton radChoose;
        private System.Windows.Forms.ComboBox cboReport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
