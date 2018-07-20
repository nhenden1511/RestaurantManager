using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManager.View
{
    public partial class PaymentReviewDialog : Form
    {
        private int _paymentId;
        public PaymentReviewDialog(int paymentId)
        {
            InitializeComponent();
            _paymentId = paymentId;
        }

        private void _rpPayment_Load(object sender, EventArgs e)
        {
            if (_paymentId == 0) return;
            var _pay = PaymentRepository.Instance.GetReportDetail(_paymentId);

            _rpPayment.LocalReport.DataSources.Clear(); //clear report
            _rpPayment.LocalReport.ReportEmbeddedResource = "RestaurantManager.Report.PaymentReport.rdlc"; // bind reportviewer with .rdlc

            ReportDataSource dataset1 = new ReportDataSource("Product", _pay.Product); // set the datasource
            _rpPayment.LocalReport.DataSources.Add(dataset1);
            dataset1.Value = _pay.Product;

            ReportDataSource dataset = new ReportDataSource("Information", _pay.Information); // set the datasource
            _rpPayment.LocalReport.DataSources.Add(dataset);
            dataset.Value = _pay.Information;

            _rpPayment.LocalReport.Refresh();
            _rpPayment.RefreshReport(); // refresh report
            this._rpPayment.RefreshReport();
        }
    }
}
