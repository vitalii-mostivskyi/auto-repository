using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using car_shop_administrative__program.DBConnection;
using car_shop_administrative__program.UI;
using car_shop_administrative__program.UI.functionsForms;

namespace car_shop_administrative__program
{
    public partial class FormAuthorization : Form
    {
        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string typedLogin = "";
            string typedPassword = "";
            if (textBoxLogin.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Заповніть всі поля");
                return;
            }
            else
            {
                typedLogin = textBoxLogin.Text;
                typedPassword = textBoxPassword.Text;

                bool logedIn = false;
                foreach (var user in carshop_db.Instance.Users)
                {
                    if (typedLogin.Equals(user.name) && typedPassword.Equals(user.password))
                    {

                        if (user.userType == "admin")
                        {
                            Form admf = new FormAdmin();
                            admf.Show();
                            Hide();
                        }
                        if (user.userType == "secretary")
                        {
                            Form admf = new FormSecretary();
                            admf.Show();
                            Hide();
                        }
                        if (user.userType == "seller")
                        {
                            FormSales fs = new FormSales("seller");
                            fs.Show();
                            Hide();
                        }

                        logedIn = true;
                        break;
                    }
                }

                if(!logedIn)
                    MessageBox.Show("Ім'я або пароль введені неправлиьно");
            }




        }
    }
}
