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
    public partial class CheckCountByDate : Form
    {
        public CheckCountByDate()
        {
            InitializeComponent();
            var model = Utill.GridCheckCount1(_dgCheckCount, DateTime.Now, DateTime.Now.AddDays(1));
            _txtCountShop.Text = model.CountShop.ToString();
            _txtPriceShop.Text = model.PriceShop.ToPrice();
            _txtSumShop.Text = model.SumShop.ToPrice();
            _txtSumAllShop.Text = model.SumAllShop.ToPrice();

            _txtCountOnline.Text = model.CountOnline.ToString();
            _txtPriceOnline.Text = model.PriceOnline.ToPrice();
            _txtSumOnline.Text = model.SumOnline.ToPrice();
            _txtSumAllOnline.Text = model.SumAllOnline.ToPrice();

            _txtCountMuti.Text = model.CountMuti.ToString();
            _txtPriceMuti.Text = model.PriceMuti.ToPrice();
            _txtSumMuti.Text = model.SumMuti.ToPrice();
            _txtSumAllMuti.Text = model.SumAllMuti.ToPrice();
        }

        private void CheckCountByDate_Load(object sender, EventArgs e)
        {

        }

        private void _dtpickStart_ValueChanged(object sender, EventArgs e)
        {
            var model = Utill.GridCheckCount1(_dgCheckCount, _dtpickStart.Value, _dtPickEnd.Value.AddDays(1));
            _txtCountShop.Text = model.CountShop.ToString();
            _txtPriceShop.Text = model.PriceShop.ToPrice();
            _txtSumShop.Text = model.SumShop.ToPrice();
            _txtSumAllShop.Text = model.SumAllShop.ToPrice();

            _txtCountOnline.Text = model.CountOnline.ToString();
            _txtPriceOnline.Text = model.PriceOnline.ToPrice();
            _txtSumOnline.Text = model.SumOnline.ToPrice();
            _txtSumAllOnline.Text = model.SumAllOnline.ToPrice();

            _txtCountMuti.Text = model.CountMuti.ToString();
            _txtPriceMuti.Text = model.PriceMuti.ToPrice();
            _txtSumMuti.Text = model.SumMuti.ToPrice();
            _txtSumAllMuti.Text = model.SumAllMuti.ToPrice();
        }

        private void _dtPickEnd_ValueChanged(object sender, EventArgs e)
        { 
            var model = Utill.GridCheckCount1(_dgCheckCount, _dtpickStart.Value, _dtPickEnd.Value.AddDays(1));
            _txtCountShop.Text = model.CountShop.ToString();
            _txtPriceShop.Text = model.PriceShop.ToPrice();
            _txtSumShop.Text = model.SumShop.ToPrice();
            _txtSumAllShop.Text = model.SumAllShop.ToPrice();

            _txtCountOnline.Text = model.CountOnline.ToString();
            _txtPriceOnline.Text = model.PriceOnline.ToPrice();
            _txtSumOnline.Text = model.SumOnline.ToPrice();
            _txtSumAllOnline.Text = model.SumAllOnline.ToPrice();

            _txtCountMuti.Text = model.CountMuti.ToString();
            _txtPriceMuti.Text = model.PriceMuti.ToPrice();
            _txtSumMuti.Text = model.SumMuti.ToPrice();
            _txtSumAllMuti.Text = model.SumAllMuti.ToPrice();
        }

        private void _dgCheckCount_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var row = e.RowIndex;
            _txtPaymentId.Text = _dgCheckCount.Rows[row].Cells[0].Value.ToString();
        }

        private void _dgCheckCount_DoubleClick(object sender, EventArgs e)
        {
            var dialog = new PaymentReviewDialog(_txtPaymentId.ToInt());
            dialog.ShowDialog();
        }
    }
}
