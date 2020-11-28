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
    public partial class UserControlAddCoach : UserControl
    {
        Database1Entities context = new Database1Entities();
        public UserControlAddCoach()
        {
            InitializeComponent();
            context.Coach.Load();
            coachBindingSource.DataSource = context.Coach.Local;
        }

        private void coachBindingNavigatorSaveItem_Click(object sender, EventArgs e)
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
