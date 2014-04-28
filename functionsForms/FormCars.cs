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
using car_shop_administrative__program.Model;

namespace car_shop_administrative__program.UI.functionsForms
{
    public partial class FormCars : Form
    {
        public FormCars()
        {
            InitializeComponent();
        }

        bool edit = false;
        Car carToEdit;

        private void buttonAddCar_Click(object sender, EventArgs e)
        {

            if (textBoxCount.Text != "" && textBoxCreationDate.Text != "" && textBoxMarka.Text != "" && textBoxModel.Text != ""
                && textBoxPrice.Text != "" && comboBoxCategory.SelectedIndex != -1 && richTextBoxDescription.Text != "")
            {
                decimal price;
                int count;
                DateTime crDate;

                try
                {
                    price = Convert.ToDecimal(textBoxPrice.Text);
                    count = Convert.ToInt32(textBoxCount.Text);
                    crDate = Convert.ToDateTime(textBoxCreationDate.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Введіть дані в правильному форматі");
                    textBoxCount.Clear();
                    textBoxPrice.Clear();
                    textBoxCreationDate.Clear();
                    return;
                }

                if (edit)
                {
                    carshop_db.Instance.Cars.DeleteOnSubmit(carToEdit);
                    carshop_db.Instance.SubmitChanges();
                }

              
                ComboBoxItem selectedItem = (ComboBoxItem)comboBoxCategory.SelectedItem;


                try
                {
                    carshop_db.Instance.Cars.InsertOnSubmit(new Car()
                    {
                        categoryId = selectedItem.Value,
                        creationDate = crDate,
                        description = richTextBoxDescription.Text,
                        id = Guid.NewGuid(),
                        marka = textBoxMarka.Text,
                        model = textBoxModel.Text,
                        price = price,
                        quantity = count

                    });

                    carshop_db.Instance.SubmitChanges();

                }
                catch (Exception)
                {
                    MessageBox.Show("Can not add data to DB");
                    return;
                }

                MessageBox.Show("Data has been seccussfuly added!");
                LoadAllCars(null);
                clear();



            }
            else
            {
                MessageBox.Show("Заповніть всі поля!!!");
            }


        }

        private void clear()
        {
            textBoxCount.Clear();
            textBoxCreationDate.Clear();
            textBoxMarka.Clear();
            textBoxModel.Clear();
            textBoxPrice.Clear();
            richTextBoxDescription.Clear();
            comboBoxCategory.SelectedIndex = -1;
        }


        private void FormCars_Load(object sender, EventArgs e)
        {
            LoadAllCars(null);
            toolStripComboBoxCategories.ComboBox.DisplayMember = "Text";
            toolStripComboBoxCategories.ComboBox.ValueMember = "Value";
         //   dataGridViewAllCars.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        //    dataGridViewAllCars.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        //    dataGridViewAllCars.Columns[4].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            List<Category> categories = carshop_db.Instance.Categories.ToList();

            foreach (Category catg in categories)
            {
                var el = new ComboBoxItem()
                {
                    Text = catg.name,
                    Value = catg.id
                };
                
                comboBoxCategory.Items.Add(el);
                toolStripComboBoxCategories.Items.Add(el);
            }

        }

        private void toolStripTextBoxAdmin_Click(object sender, EventArgs e)
        {

        }

        private void LoadAllCars(Guid? categoryId)
        {
            dataGridViewAllCars.Rows.Clear();
            List<Car> cars;
            if (categoryId == null)
                cars = carshop_db.Instance.Cars.ToList();
            else
                cars = carshop_db.Instance.Cars.Where(x => x.categoryId == categoryId).ToList();

            foreach (Car car in cars)
            {

                dataGridViewAllCars.Rows.Add(new object[]{

                    car.model,
                    car.marka,
                    car.Category.name,
                    car.description,
                    car.quantity,
                    car.price,
                    car.creationDate,
                    car.id,
                    "редагувати",
                    "видалити"
                });
            }
        }

        private void toolStripComboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItem selectedItem = (ComboBoxItem)toolStripComboBoxCategories.SelectedItem;
            LoadAllCars(selectedItem.Value);
        }

        private void dataGridViewAllCars_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridViewAllCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            switch (e.ColumnIndex)
            {
                case 8:

                    prepareCarForEdit((Guid)dataGridViewAllCars.Rows[e.RowIndex].Cells[7].Value);
                    buttonCancelEdit.Visible = true;
                    tabControl1.SelectedIndex = 0;

                    break;
                case 9:

                    var confirmResult = MessageBox.Show("Точно видалити ??",
                        "Підтвердити видалення",
                        MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                        if(deleteCar((Guid)dataGridViewAllCars.Rows[e.RowIndex].Cells[7].Value))
                            LoadAllCars(null);

                    break;
            }
        }

        bool deleteCar(Guid id)
        {
            bool success = false;

            try
            {
                var carToDelete = carshop_db.Instance.Cars.Single(x => x.id.Equals(id));
                carshop_db.Instance.Cars.DeleteOnSubmit(carToDelete);
                carshop_db.Instance.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Can not delete user");
                return false;
            }

            MessageBox.Show("Car has been deleted");
            success = true;
            return success;
        }

        void prepareCarForEdit(Guid id)
        {
            carToEdit = carshop_db.Instance.Cars.Single(x => x.id.Equals(id));

            textBoxCount.Text = carToEdit.quantity.ToString();
            textBoxCreationDate.Text = carToEdit.creationDate.ToString();
            textBoxMarka.Text = carToEdit.marka;
            textBoxModel.Text = carToEdit.model;
            textBoxPrice.Text = carToEdit.price.ToString();
            richTextBoxDescription.Text = carToEdit.description;
            comboBoxCategory.SelectedIndex = comboBoxCategory.FindStringExact(carToEdit.Category.name);

            edit = true;
        }

        private void FormCars_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItemAllCars_Click(object sender, EventArgs e)
        {
            LoadAllCars(null);
        }

        private void buttonCancelEdit_Click(object sender, EventArgs e)
        {
            edit = false;
            carToEdit = null;
            clear();
            buttonCancelEdit.Visible = false;
        }

    }
}
