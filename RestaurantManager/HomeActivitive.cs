using RestaurantManager.Position;
using RestaurantManager.Server;
using RestaurantManager.View.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManager
{
    public partial class HomeActivitive : Form
    {
        public HomeActivitive()
        {
            InitializeComponent();
        }

        private void HomeActivitive_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Maximized;
            Screen scr = Screen.PrimaryScreen; //đi lấy màn hình chính
            _grTable.Left = 230;
            _grTable.Top = 110;
            GetListView();
            GetTable();
            
            //_grTable.Right = (scr.WorkingArea.Height)/ 2;
            //_grTable.Bottom = (scr.WorkingArea.Height)/ 2;
        }

        private void HomeActivitive_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void _btnArea_Click(object sender, EventArgs e)
        {
            var _areaFunction = new AreaFunction(DbConnect.XConnect());
            var areaDialog = new AreaDialog(_areaFunction);
            areaDialog.ShowDialog();
        }

        private void _btnConnect_Click(object sender, EventArgs e)
        {
            DbConnect.Connect();
        }

        private void _btnTable_Click(object sender, EventArgs e)
        {
            var tableDialog = new TableDialog(new TableFunction(DbConnect.XConnect()), new AreaFunction(DbConnect.XConnect()));
            tableDialog.ShowDialog();
        }
        private void GetTable()
        {
            var _tableFunction = new TableFunction(DbConnect.XConnect());
            DataTable dt = _tableFunction.LoadTable();
           
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = row[2].ToString();
                item.SubItems.Add(row["Id"].ToString());
                item.SubItems.Add(row["AreaId"].ToString());
                item.SubItems.Add(row["Name"].ToString());
                string trangthai = row["Status"].ToString();
                if (trangthai == "1")
                {
                    item.ImageIndex = 0;
                }
                else
                    item.ImageIndex = 0;

                _lvTable.Items.Add(item);
            }
        }

        private void _lvTable_DoubleClick(object sender, EventArgs e)
        {
            //MessageBox.Show(_lvTable.SelectedItems[3].SubItems[2].Text);
            //MessageBox.Show("12");
        }

        private void _lvTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem item = _lvTable.SelectedItems[0];
            _txtTable.Text = item.SubItems[1].Text.ToString().Trim();
        }

        private void GetListView()
        {
            _imageTable.ImageSize = Contant.ImageSize();
            _imageTable.Images.Add("pic1", Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\image\MB__home.png"));
            _lvTable.LargeImageList = _imageTable;
            _imageTable.ColorDepth = ColorDepth.Depth32Bit;
            _lvTable.Font = Contant.ImageFont();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _lvTable.Clear();
            GetTable();
        }

        private void _btnGenusViand_Click(object sender, EventArgs e)
        {
            var genusDialog = new GenusDialog(new GenusFunction(DbConnect.XConnect()));
            genusDialog.Show();
        }

        private void _btnViand_Click(object sender, EventArgs e)
        {
            var viandDialog = new ViandDialog(new GenusFunction(DbConnect.XConnect()), new ViandFunction(DbConnect.XConnect()));
            viandDialog.Show();
        }
    }
}
