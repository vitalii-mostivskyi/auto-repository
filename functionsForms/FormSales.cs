using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using car_shop_administrative__program.DBConnection;
using car_shop_administrative__program.DBConnection.Entities;

namespace car_shop_administrative__program.UI.functionsForms
{
    public partial class FormSales : Form
    {
        string userType;

        public FormSales(string type)
        {
            InitializeComponent();
            userType = type;
        }

        private void FormSales_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void LoadOrders()
        {
            dataGridViewAllSales.Rows.Clear();
            List<Order> orders = null;

            if (userType == "admin")
            {
                dataGridViewAllSales.Columns["ColumnPerformOrder"].Visible = false;
                dataGridViewAllSales.Columns["ColumnSuccess"].Visible = true;
                orders = carshop_db.Instance.Orders.ToList();
            }
            if (userType == "secretary")
            {
                dataGridViewAllSales.Columns["ColumnPerformOrder"].Visible = false;
                dataGridViewAllSales.Columns["ColumnSuccess"].Visible = false;
                orders = carshop_db.Instance.Orders.Where(x => x.success).ToList();
            }
            if (userType == "seller")
            {
                dataGridViewAllSales.Columns["ColumnPerformOrder"].Visible = true;
                dataGridViewAllSales.Columns["ColumnSuccess"].Visible = false;
                orders = carshop_db.Instance.Orders.Where(x => !x.success).ToList();
            }

            foreach (Order order in orders)
            {
                dataGridViewAllSales.Rows.Add(new object[] {
                
                    order.User.getFullName(),
                    order.Car.GetName(),
                    order.orderDate,
                    order.carCount,
                    order.Car.price,
                    order.GetOrderTotalSum(),
                    order.success,
                    "Оформити",
                    order.id
                });
            }

        }

        private void dataGridViewAllSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                FormPerformOrder pof = new FormPerformOrder((Guid)dataGridViewAllSales.Rows[e.RowIndex].Cells["Id"].Value);
                pof.ShowDialog();
                LoadOrders();
            }
        }

        private void FormSales_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
