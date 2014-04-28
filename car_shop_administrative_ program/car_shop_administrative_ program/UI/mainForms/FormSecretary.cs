using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using car_shop_administrative__program.UI.functionsForms;

namespace car_shop_administrative__program.UI
{
    public partial class FormSecretary : Form
    {
        public FormSecretary()
        {
            InitializeComponent();
        }

        private void buttonCars_Click(object sender, EventArgs e)
        {
            FormCars fCars = new FormCars();
            fCars.Show();
            Close();
        }

        private void FormSecretary_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void buttonAllSales_Click(object sender, EventArgs e)
        {
            FormSales fs = new FormSales("secretary");
            fs.Show();
            Close();
        }
    }
}
