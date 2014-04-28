using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using car_shop_administrative__program.DBConnection;

namespace car_shop_administrative__program.UI.functionsForms
{
    public partial class FormPerformOrder : Form
    {

        private Guid orderId;

        public FormPerformOrder(Guid id)
        {
            InitializeComponent();
            orderId = id;
        }

        private void buttonPerformBuy_Click(object sender, EventArgs e)
        {
            if (textBoxPhone.Text != "")
            {
                long phone;
                try
                {
                    phone = Convert.ToInt64(textBoxPhone.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Телефон в неправельному форматі");
                    textBoxPhone.Clear();
                    return;
                }

                string userPhone = carshop_db.Instance.Orders.Single(x => x.id == orderId).User.phone;
                if (phone.ToString() == userPhone)
                {
                    try
                    {
                        carshop_db.Instance.Orders.Single(x => x.id == orderId).success = true;
                        carshop_db.Instance.SubmitChanges();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Покупка не здійснилась");
                        return;
                    }

                    MessageBox.Show("Покупка здійснена!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Неправильний телефон");
                    return;
                }

               
            }
            else
                MessageBox.Show("Заповніть поле!");
        }

        private void FormPerformOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
