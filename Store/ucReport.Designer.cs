
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
            this.pnl = new System.Windows.Forms.Panel();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.cbo = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.radSales = new System.Windows.Forms.RadioButton();
            this.radImport = new System.Windows.Forms.RadioButton();
            this.radProducts4Cate = new System.Windows.Forms.RadioButton();
            this.radAllProducts = new System.Windows.Forms.RadioButton();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.pnl.Controls.Add(this.dtp);
            this.pnl.Controls.Add(this.cbo);
            this.pnl.Controls.Add(this.btnOk);
            this.pnl.Controls.Add(this.radSales);
            this.pnl.Controls.Add(this.radImport);
            this.pnl.Controls.Add(this.radProducts4Cate);
            this.pnl.Controls.Add(this.radAllProducts);
            this.pnl.Location = new System.Drawing.Point(370, 120);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(460, 400);
            this.pnl.TabIndex = 0;
            // 
            // dtp
            // 
            this.dtp.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(110, 243);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(240, 28);
            this.dtp.TabIndex = 3;
            // 
            // cbo
            // 
            this.cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo.FormattingEnabled = true;
            this.cbo.Location = new System.Drawing.Point(110, 243);
            this.cbo.Name = "cbo";
            this.cbo.Size = new System.Drawing.Size(240, 29);
            this.cbo.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(1)))), ((int)(((byte)(243)))));
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(1)))), ((int)(((byte)(243)))));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(1)))), ((int)(((byte)(243)))));
            this.btnOk.Location = new System.Drawing.Point(180, 315);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 40);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            this.btnOk.MouseEnter += new System.EventHandler(this.btnOk_MouseEnter);
            this.btnOk.MouseLeave += new System.EventHandler(this.btnOk_MouseLeave);
            // 
            // radSales
            // 
            this.radSales.AutoSize = true;
            this.radSales.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSales.ForeColor = System.Drawing.Color.White;
            this.radSales.Location = new System.Drawing.Point(85, 187);
            this.radSales.Name = "radSales";
            this.radSales.Size = new System.Drawing.Size(283, 25);
            this.radSales.TabIndex = 0;
            this.radSales.TabStop = true;
            this.radSales.Text = "SALES - INVOICES FOR MONTH";
            this.radSales.UseVisualStyleBackColor = true;
            this.radSales.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // radImport
            // 
            this.radImport.AutoSize = true;
            this.radImport.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radImport.ForeColor = System.Drawing.Color.White;
            this.radImport.Location = new System.Drawing.Point(85, 145);
            this.radImport.Name = "radImport";
            this.radImport.Size = new System.Drawing.Size(302, 25);
            this.radImport.TabIndex = 0;
            this.radImport.TabStop = true;
            this.radImport.Text = "IMPORT - INVOICES FOR MONTH";
            this.radImport.UseVisualStyleBackColor = true;
            this.radImport.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // radProducts4Cate
            // 
            this.radProducts4Cate.AutoSize = true;
            this.radProducts4Cate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radProducts4Cate.ForeColor = System.Drawing.Color.White;
            this.radProducts4Cate.Location = new System.Drawing.Point(85, 103);
            this.radProducts4Cate.Name = "radProducts4Cate";
            this.radProducts4Cate.Size = new System.Drawing.Size(259, 25);
            this.radProducts4Cate.TabIndex = 0;
            this.radProducts4Cate.TabStop = true;
            this.radProducts4Cate.Text = "PRODUCTS FOR CATEGORY";
            this.radProducts4Cate.UseVisualStyleBackColor = true;
            this.radProducts4Cate.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // radAllProducts
            // 
            this.radAllProducts.AutoSize = true;
            this.radAllProducts.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAllProducts.ForeColor = System.Drawing.Color.White;
            this.radAllProducts.Location = new System.Drawing.Point(85, 61);
            this.radAllProducts.Name = "radAllProducts";
            this.radAllProducts.Size = new System.Drawing.Size(155, 25);
            this.radAllProducts.TabIndex = 0;
            this.radAllProducts.TabStop = true;
            this.radAllProducts.Text = "ALL PRODUCTS";
            this.radAllProducts.UseVisualStyleBackColor = true;
            this.radAllProducts.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // ucReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.pnl);
            this.Name = "ucReport";
            this.Size = new System.Drawing.Size(1200, 700);
            this.Load += new System.EventHandler(this.ucReport_Load);
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.RadioButton radSales;
        private System.Windows.Forms.RadioButton radImport;
        private System.Windows.Forms.RadioButton radProducts4Cate;
        private System.Windows.Forms.RadioButton radAllProducts;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox cbo;
        private System.Windows.Forms.DateTimePicker dtp;
    }
}
