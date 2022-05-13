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
    public partial class MainForm : Form
    {
        public static DataClassesDataContext DatabaseDT = new DataClassesDataContext(); 
        public MainForm()
        {
            InitializeComponent();

            RefreshPersonList();
        }

        private void RefreshPersonList()
        {
            listBoxPerson.Items.Clear();
            listBoxPerson.Items.AddRange(DatabaseDT.PERSONs.ToArray());
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxPerson.SelectedItem != null)
            {
                if (listBoxPerson.SelectedItem is PERSON p)
                {

                    if(MessageBox.Show("Do you want to delete selected person?",
                       "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DatabaseDT.CARs.DeleteAllOnSubmit(p.CARs);
                        DatabaseDT.PERSONs.DeleteOnSubmit(p);
                        DatabaseDT.SubmitChanges();
                        RefreshPersonList();
                    }
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormEditPerson form = new FormEditPerson();
            if (form.ShowDialog() != DialogResult.OK)
            {
                PERSON toDelete = form.editPerson;
                DatabaseDT.CARs.DeleteAllOnSubmit(toDelete.CARs);
                DatabaseDT.PERSONs.DeleteOnSubmit(toDelete);
                DatabaseDT.SubmitChanges();
                RefreshPersonList();
            }
            RefreshPersonList();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxPerson.SelectedItem != null)
            {
                if (listBoxPerson.SelectedItem is PERSON p)
                {
                    FormEditPerson form = new FormEditPerson(p);
                    if (form.ShowDialog() != DialogResult.OK)
                    {
                        //pass
                    }
                    RefreshPersonList();
                }
            }


        }
    }

    partial class PERSON
    {
        public override string ToString()
        {
            return name + ", DL received: " + driver_license_date.ToShortDateString() +
                " (cars count: " + CARs.Count() + ")";
        }
    }

    partial class CAR
    {
        public override string ToString()
        {
            return mark + " (" + price + "$)";
        }
    }
}
