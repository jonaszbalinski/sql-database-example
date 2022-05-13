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
        PERSON editPerson = null;
        public FormEditPerson(PERSON p = null)
        {
            InitializeComponent();

            if (p != null)
            {
                textBox1.Text = p.name;
                dateTimePicker1.Value = p.driver_license_date;
                editPerson = p;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(editPerson != null)
            {
                editPerson.name = textBox1.Text;
                editPerson.driver_license_date = dateTimePicker1.Value;
            }
            else
            {
                PERSON person = new PERSON();

                person.name = textBox1.Text;
                person.driver_license_date = dateTimePicker1.Value;

                MainForm.DatabaseDT.PERSONs.InsertOnSubmit(person);
            }

            MainForm.DatabaseDT.SubmitChanges();
            DialogResult = DialogResult.OK;
        }
    }
}
