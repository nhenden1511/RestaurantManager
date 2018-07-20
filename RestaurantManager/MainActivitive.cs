using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace RestaurantManager
{
    public partial class LoginActivitive : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;
        private bool AdminExist;
        public LoginActivitive()
        {
            InitializeComponent();
            AdminExist = true;
            var admin = DataHelper.Instance.GetByAdmin();
            if (admin == null)
            {
                _lbPassConfirm.Visible = true;
                _txtPasswordConfirm.Visible = true;
                AdminExist = false;
            }
        }
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams myCp = base.CreateParams;
        //        myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
        //        return myCp;
        //    }
        //}
        private void btLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            var username = _txtUserName.Text;
            var passcode = _txtPassword.Text;
            if (String.IsNullOrWhiteSpace(username) || String.IsNullOrWhiteSpace(passcode)) return;

            if (!AdminExist)
            {
                var passConfirm = _txtPasswordConfirm.Text;
                if (passcode != passConfirm)
                {
                    MessageBox.Show("Bạn Nhập Sai Mật Khẩu và Mật Khẩu Xác Nhận !");
                    return;
                }
                Utill.Person = new Person()
                {
                    UserName = username,
                    Passcode = passcode,
                    IsAddmin = true,
                };
                PersonRepository.Instance.Insert(Utill.Person);
            }

            var person = DataHelper.Instance.GetPersonByName(username);
            if (person == null)
            {
                MessageBox.Show("Bạn Nhập Sai Tên Hoặc Mật Khẩu !");
            }
            else
            {
                Utill.Person = person;
                this.Close();
                DialogResult = DialogResult.OK;
            }
        }
        private void _txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Login();
            }
        }

        private void _txtPasswordConfirm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Login();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
