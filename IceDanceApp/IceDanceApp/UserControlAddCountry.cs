using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace IceDanceApp
{
    public partial class UserControlAddCountry : UserControl
    {
        Database1Entities context = new Database1Entities();
        public UserControlAddCountry()
        {
            InitializeComponent();
            context.Country.Load();
            countryBindingSource.DataSource = context.Country.Local;
        }

        private void countryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                context.SaveChanges();
                MessageBox.Show("Megtörtént a mentés, hurrá 👍");
            }
            catch (Exception)
            {

                MessageBox.Show("nem jó");
            }
        }
    }
}
