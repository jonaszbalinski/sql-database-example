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
                    if (p.CARs.Count == 0)
                    {
                        if(MessageBox.Show("Do you want to delete selected person?",
                            "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            DatabaseDT.PERSONs.DeleteOnSubmit(p);
                            DatabaseDT.SubmitChanges();
                            RefreshPersonList();
                        }
                        return;
                    }

                    DialogResult result = MessageBox
                        .Show("Do you want to delete selected person with cars?",
                        "Warning", MessageBoxButtons.YesNoCancel);

                    if (result == DialogResult.Yes)
                    {
                        DatabaseDT.CARs.DeleteAllOnSubmit(p.CARs);
                        DatabaseDT.PERSONs.DeleteOnSubmit(p);
                        DatabaseDT.SubmitChanges();
                        RefreshPersonList();
                    }
                    else if (result == DialogResult.No)
                    {
                        foreach (CAR car in p.CARs)
                        {
                            car.person_id = null;
                        }
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
            if (form.ShowDialog() == DialogResult.OK)
            {
                RefreshPersonList();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxPerson.SelectedItem != null)
            {
                if (listBoxPerson.SelectedItem is PERSON p)
                {
                    FormEditPerson form = new FormEditPerson(p);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        RefreshPersonList();
                    }
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
            string toReturn = mark + " (" + price + "$)";
            if (person_id != null) toReturn += " owned by: " + person_id.ToString();

            return toReturn;
        }
    }
}
