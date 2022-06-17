
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
            this.dgvSalesInvoice = new System.Windows.Forms.DataGridView();
            this.colInvoiceIDSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSizeSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriceSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantitySale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radSales = new System.Windows.Forms.RadioButton();
            this.radImport = new System.Windows.Forms.RadioButton();
            this.cboReport = new System.Windows.Forms.ComboBox();
            this.dgvImportInvoice = new System.Windows.Forms.DataGridView();
            this.colInvoiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceDetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImportPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSalesInvoice
            // 
            this.dgvSalesInvoice.AllowUserToAddRows = false;
            this.dgvSalesInvoice.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.dgvSalesInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSalesInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInvoiceIDSale,
            this.colInvoiceDetail,
            this.colCustomer,
            this.colStaffName,
            this.colProduct,
            this.colSizeSale,
            this.colPriceSale,
            this.colQuantitySale,
            this.colDate});
            this.dgvSalesInvoice.Location = new System.Drawing.Point(50, 100);
            this.dgvSalesInvoice.Name = "dgvSalesInvoice";
            this.dgvSalesInvoice.RowHeadersVisible = false;
            this.dgvSalesInvoice.RowHeadersWidth = 51;
            this.dgvSalesInvoice.RowTemplate.Height = 24;
            this.dgvSalesInvoice.Size = new System.Drawing.Size(1100, 550);
            this.dgvSalesInvoice.TabIndex = 6;
            // 
            // colInvoiceIDSale
            // 
            this.colInvoiceIDSale.HeaderText = "Invoice ID";
            this.colInvoiceIDSale.MinimumWidth = 6;
            this.colInvoiceIDSale.Name = "colInvoiceIDSale";
            this.colInvoiceIDSale.Width = 125;
            // 
            // colInvoiceDetail
            // 
            this.colInvoiceDetail.HeaderText = "Invoice Detail";
            this.colInvoiceDetail.MinimumWidth = 6;
            this.colInvoiceDetail.Name = "colInvoiceDetail";
            this.colInvoiceDetail.Width = 125;
            // 
            // colCustomer
            // 
            this.colCustomer.HeaderText = "Customer";
            this.colCustomer.MinimumWidth = 6;
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.Width = 125;
            // 
            // colStaffName
            // 
            this.colStaffName.HeaderText = "StaffName";
            this.colStaffName.MinimumWidth = 6;
            this.colStaffName.Name = "colStaffName";
            this.colStaffName.Width = 125;
            // 
            // colProduct
            // 
            this.colProduct.HeaderText = "Product";
            this.colProduct.MinimumWidth = 6;
            this.colProduct.Name = "colProduct";
            this.colProduct.Width = 125;
            // 
            // colSizeSale
            // 
            this.colSizeSale.HeaderText = "Size";
            this.colSizeSale.MinimumWidth = 6;
            this.colSizeSale.Name = "colSizeSale";
            this.colSizeSale.Width = 125;
            // 
            // colPriceSale
            // 
            this.colPriceSale.HeaderText = "Price";
            this.colPriceSale.MinimumWidth = 6;
            this.colPriceSale.Name = "colPriceSale";
            this.colPriceSale.Width = 125;
            // 
            // colQuantitySale
            // 
            this.colQuantitySale.HeaderText = "Quantity";
            this.colQuantitySale.MinimumWidth = 6;
            this.colQuantitySale.Name = "colQuantitySale";
            this.colQuantitySale.Width = 125;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.Width = 125;
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
            this.radImport.Location = new System.Drawing.Point(224, 40);
            this.radImport.Name = "radImport";
            this.radImport.Size = new System.Drawing.Size(154, 25);
            this.radImport.TabIndex = 8;
            this.radImport.TabStop = true;
            this.radImport.Text = "Import-Invoice";
            this.radImport.UseVisualStyleBackColor = true;
            this.radImport.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // cboReport
            // 
            this.cboReport.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboReport.FormattingEnabled = true;
            this.cboReport.Location = new System.Drawing.Point(425, 39);
            this.cboReport.Name = "cboReport";
            this.cboReport.Size = new System.Drawing.Size(345, 29);
            this.cboReport.TabIndex = 9;
            // 
            // dgvImportInvoice
            // 
            this.dgvImportInvoice.AllowUserToAddRows = false;
            this.dgvImportInvoice.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.dgvImportInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvImportInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImportInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInvoiceID,
            this.colInvoiceDetailID,
            this.colAccountName,
            this.colProductname,
            this.colSize,
            this.colQuantity,
            this.colDateAdded,
            this.colImportPrice});
            this.dgvImportInvoice.Location = new System.Drawing.Point(50, 100);
            this.dgvImportInvoice.Name = "dgvImportInvoice";
            this.dgvImportInvoice.RowHeadersVisible = false;
            this.dgvImportInvoice.RowHeadersWidth = 51;
            this.dgvImportInvoice.RowTemplate.Height = 24;
            this.dgvImportInvoice.Size = new System.Drawing.Size(1100, 550);
            this.dgvImportInvoice.TabIndex = 10;
            // 
            // colInvoiceID
            // 
            this.colInvoiceID.HeaderText = "Invoice ID";
            this.colInvoiceID.MinimumWidth = 6;
            this.colInvoiceID.Name = "colInvoiceID";
            this.colInvoiceID.Width = 125;
            // 
            // colInvoiceDetailID
            // 
            this.colInvoiceDetailID.HeaderText = "Invoice Detail ID";
            this.colInvoiceDetailID.MinimumWidth = 6;
            this.colInvoiceDetailID.Name = "colInvoiceDetailID";
            this.colInvoiceDetailID.Width = 125;
            // 
            // colAccountName
            // 
            this.colAccountName.HeaderText = "Account Name";
            this.colAccountName.MinimumWidth = 6;
            this.colAccountName.Name = "colAccountName";
            this.colAccountName.Width = 125;
            // 
            // colProductname
            // 
            this.colProductname.HeaderText = "Product Name";
            this.colProductname.MinimumWidth = 6;
            this.colProductname.Name = "colProductname";
            this.colProductname.Width = 125;
            // 
            // colSize
            // 
            this.colSize.HeaderText = "Size";
            this.colSize.MinimumWidth = 6;
            this.colSize.Name = "colSize";
            this.colSize.Width = 125;
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.MinimumWidth = 6;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Width = 125;
            // 
            // colDateAdded
            // 
            this.colDateAdded.HeaderText = "Date Added";
            this.colDateAdded.MinimumWidth = 6;
            this.colDateAdded.Name = "colDateAdded";
            this.colDateAdded.Width = 125;
            // 
            // colImportPrice
            // 
            this.colImportPrice.HeaderText = "Import Price";
            this.colImportPrice.MinimumWidth = 6;
            this.colImportPrice.Name = "colImportPrice";
            this.colImportPrice.Width = 125;
            // 
            // ucReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.dgvImportInvoice);
            this.Controls.Add(this.cboReport);
            this.Controls.Add(this.radImport);
            this.Controls.Add(this.radSales);
            this.Controls.Add(this.dgvSalesInvoice);
            this.Name = "ucReport";
            this.Size = new System.Drawing.Size(1200, 700);
            this.Load += new System.EventHandler(this.ucReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportInvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSalesInvoice;
        private System.Windows.Forms.RadioButton radSales;
        private System.Windows.Forms.RadioButton radImport;
        private System.Windows.Forms.ComboBox cboReport;
        private System.Windows.Forms.DataGridView dgvImportInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceDetailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateAdded;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImportPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceIDSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSizeSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriceSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantitySale;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
    }
}
