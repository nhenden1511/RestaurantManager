namespace RestaurantManager.View
{
    partial class PaymentReviewDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentReviewDialog));
            this._rpPayment = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // _rpPayment
            // 
            this._rpPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this._rpPayment.LocalReport.ReportEmbeddedResource = "RestaurantManager.Report.PaymentReport.rdlc";
            this._rpPayment.Location = new System.Drawing.Point(0, 0);
            this._rpPayment.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this._rpPayment.Name = "_rpPayment";
            this._rpPayment.Size = new System.Drawing.Size(308, 493);
            this._rpPayment.TabIndex = 1;
            this._rpPayment.Load += new System.EventHandler(this._rpPayment_Load);
            // 
            // PaymentReviewDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 493);
            this.Controls.Add(this._rpPayment);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaymentReviewDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hóa Đơn";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer _rpPayment;
    }
}