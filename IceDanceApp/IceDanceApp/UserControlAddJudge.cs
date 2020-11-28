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
    public partial class UserControlAddJudge : UserControl
    {
        Database1Entities context = new Database1Entities();
        public UserControlAddJudge()
        {
            InitializeComponent();
            context.Judge.Load();
            judgeBindingSource.DataSource = context.Judge.Local;
        }

        private void judgeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
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
