using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sql_database_example
{
    public partial class FormEditPerson : Form
    {
        public PERSON editPerson = null;
        public FormEditPerson(PERSON p = null)
        {
            InitializeComponent();

            if (p != null)
            {
                textBoxName.Text = p.name;
                dateTimePicker.Value = p.driver_license_date;
                editPerson = p;
            }
            else
            {
                editPerson = new PERSON();
                editPerson.name = "";
                editPerson.driver_license_date = DateTime.Now;

                MainForm.DatabaseDT.PERSONs.InsertOnSubmit(editPerson);
                MainForm.DatabaseDT.SubmitChanges();
            }

            loadCarList();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            editPerson.name = textBoxName.Text;
            editPerson.driver_license_date = dateTimePicker.Value;
            MainForm.DatabaseDT.SubmitChanges();
            DialogResult = DialogResult.OK;
        }

        private void loadCarList()
        {
            listBoxCars.Items.Clear();
            if (editPerson != null)
            {
                foreach (CAR car in editPerson.CARs)
                {
                    listBoxCars.Items.Add(car);
                }
            }
        }

        private void buttonAddCar_Click(object sender, EventArgs e)
        {
            CAR car = new CAR();
            car.mark = textBoxMark.Text;
            car.price = numericUpDownPrice.Value;
            editPerson.CARs.Add(car);
            MainForm.DatabaseDT.SubmitChanges();
            loadCarList();
        }

        private void buttonDeleteCar_Click(object sender, EventArgs e)
        {
            if (listBoxCars.SelectedItem != null)
            {
                if (listBoxCars.SelectedItem is CAR car)
                {
                    MainForm.DatabaseDT.CARs.DeleteOnSubmit(car);
                    MainForm.DatabaseDT.SubmitChanges();
                    loadCarList();
                }
            }
        }
    }
}
