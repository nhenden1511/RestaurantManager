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
    public partial class ProductInventoryDialog : Form
    {
        static int _groupId;
        public ProductInventoryDialog()
        {
            InitializeComponent();
            Utill.ComboGroup(_cbbGroup,true);
            _groupId = _txtGroupId.ToInt();
        }

        private void _cbbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            var data = _cbbGroup.SelectedItem as ProductGroup;
            _txtGroupId.Text = data.Id.ToString();
            _groupId = data.Id;
            Utill.InventoryProduct(_dgProduct, data.Id,_txtSumCount,_txtSumPrice);
        }


    }
}
