
namespace Jewelry
{
    partial class frmViewReport
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlClose = new System.Windows.Forms.Panel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.rvr = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlHeader.SuspendLayout();
            this.pnlClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(1)))), ((int)(((byte)(243)))));
            this.pnlHeader.Controls.Add(this.pnlClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1440, 32);
            this.pnlHeader.TabIndex = 2;
            // 
            // pnlClose
            // 
            this.pnlClose.BackColor = System.Drawing.Color.Transparent;
            this.pnlClose.Controls.Add(this.picClose);
            this.pnlClose.Location = new System.Drawing.Point(1402, 0);
            this.pnlClose.Name = "pnlClose";
            this.pnlClose.Size = new System.Drawing.Size(38, 32);
            this.pnlClose.TabIndex = 2;
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.Image = global::Jewelry.Properties.Resources.close;
            this.picClose.Location = new System.Drawing.Point(8, 5);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(22, 22);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 3;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            this.picClose.MouseEnter += new System.EventHandler(this.picClose_MouseEnter);
            this.picClose.MouseLeave += new System.EventHandler(this.picClose_MouseLeave);
            // 
            // rvr
            // 
            this.rvr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvr.Location = new System.Drawing.Point(0, 32);
            this.rvr.Name = "rvr";
            this.rvr.ServerReport.BearerToken = null;
            this.rvr.Size = new System.Drawing.Size(1440, 778);
            this.rvr.TabIndex = 3;
            // 
            // frmViewReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1440, 810);
            this.Controls.Add(this.rvr);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmViewReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmViewReport_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlClose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlClose;
        private System.Windows.Forms.PictureBox picClose;
        private Microsoft.Reporting.WinForms.ReportViewer rvr;
    }
}