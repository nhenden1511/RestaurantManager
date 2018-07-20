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
    public partial class DeleteProductDialog : Form
    {
        private int _productId;
        private string _productCode;
        public DeleteProductDialog(int productId, string productCode)
        {
            InitializeComponent();
            _productId = productId;
            _productCode = productCode;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_txtProductCode.Text == _productCode)
            { 
                var entity = ProductRepository.Instance.GetById(_productId);
                entity.IsDelete = true;
                ProductRepository.Instance.Update(entity);
                this.Close();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
