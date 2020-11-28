using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IceDanceApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonNewCompetition_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControlAddCompetition uc = new UserControlAddCompetition();
            panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void buttonAddCompetitor_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControlAddCompetitors uc = new UserControlAddCompetitors();
            panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void buttonAddCoach_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControlAddCoach uc = new UserControlAddCoach();
            panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void buttonAddJudge_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControlAddJudge uc = new UserControlAddJudge();
            panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void buttonAddCountry_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControlAddCountry uc = new UserControlAddCountry();
            panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }
    }
}
