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
        DataClassesDataContext DatabaseDT = new DataClassesDataContext(); 
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
                if(listBoxPerson.SelectedItem is PERSON)
                {
                    PERSON p = (PERSON)listBoxPerson.SelectedItem;

                    if(MessageBox.Show("Do you want to delete selected person with cars", 
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
    }

    partial class PERSON
    {
        public override string ToString()
        {
            return name + ", DL received: " + driver_license_date.ToShortDateString() +
                " (ilość pojazdów: " + CARs.Count() + ")";
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
