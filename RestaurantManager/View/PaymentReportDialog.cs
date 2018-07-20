using Microsoft.Reporting.WinForms;
using RestaurantManager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RestaurantManager.UtillEnum;

namespace RestaurantManager.View
{
    public partial class PaymentReportDialog : Form
    {
        private int m_currentPageIndex;
        private IList<Stream> m_streams;
        private int _ship;
        private int _sale;
        private int _bonus;
        private string _customer;
        private ReportModel _pay;
        private PaymentType _paymentType;
        public PaymentReportDialog(PaymentType type, int ship, int sale, int bonus, string customer)
        {
            InitializeComponent();
            _ship = ship;
            _sale = sale;
            _bonus = bonus;
            _customer = customer;
            _paymentType = type;
        }

        private void PaymentReportDialog_Load(object sender, EventArgs e)
        {
            _pay = OrderRepository.Instance.SaveAndGetReport(_sale,_ship,_bonus,_customer);

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

            var printerName =  _rpPayment.PrinterSettings.PrinterName;
        }

        private void _btnPrint_Click(object sender, EventArgs e)
        {
            _pay.Payment.PaymentType = _paymentType;
            PaymentRepository.Instance.SavePayment(_pay.Payment);
            this.Close();
            DialogResult = DialogResult.OK;
        }
    }
}
