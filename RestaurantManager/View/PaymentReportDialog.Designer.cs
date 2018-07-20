namespace RestaurantManager.View
{
    partial class PaymentReportDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentReportDialog));
            this._rpPayment = new Microsoft.Reporting.WinForms.ReportViewer();
            this._btnPayment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _rpPayment
            // 
            this._rpPayment.LocalReport.ReportEmbeddedResource = "RestaurantManager.Report.PaymentReport.rdlc";
            this._rpPayment.Location = new System.Drawing.Point(7, 0);
            this._rpPayment.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this._rpPayment.Name = "_rpPayment";
            this._rpPayment.Size = new System.Drawing.Size(300, 485);
            this._rpPayment.TabIndex = 0;
            // 
            // _btnPayment
            // 
            this._btnPayment.BackgroundImage = global::RestaurantManager.Properties.Resources.ic_base_button_red;
            this._btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnPayment.Location = new System.Drawing.Point(83, 491);
            this._btnPayment.Name = "_btnPayment";
            this._btnPayment.Size = new System.Drawing.Size(148, 49);
            this._btnPayment.TabIndex = 1;
            this._btnPayment.Text = "Đã Thanh Toán";
            this._btnPayment.UseVisualStyleBackColor = true;
            this._btnPayment.Click += new System.EventHandler(this._btnPrint_Click);
            // 
            // PaymentReportDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(314, 549);
            this.Controls.Add(this._btnPayment);
            this.Controls.Add(this._rpPayment);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaymentReportDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.PaymentReportDialog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer _rpPayment;
        private System.Windows.Forms.Button _btnPayment;
    }
}