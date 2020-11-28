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
    public partial class Form1 : Form
    {
        Database1Entities context = new Database1Entities();

        public Form1()
        {
            InitializeComponent();
            coupleRankList();
        }

        private void coupleRankList()
        {
            var rank = from x in context.Competition_Couple
                       group x by new { x.Couple.Competitor.Name } into g
                       select new Ranking()
                       {
                           Name = g.Key.Name,
                           Point = (from x in g select 10 - x.Rank.Value).Sum()
                       };



            rankingBindingSource.DataSource = rank.OrderByDescending(x => x.Point).ThenBy(x => x.Name).ToList();
        }


        private void buttonNewCompetition_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            UserControlAddCompetition uc = new UserControlAddCompetition();
            f2.panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            f2.ShowDialog();
        }

        private void buttonAddCompetitor_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            UserControlAddCompetitors uc = new UserControlAddCompetitors();
            f2.panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            f2.ShowDialog();
        }

        private void buttonAddCoach_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            UserControlAddCoach uc = new UserControlAddCoach();
            f2.panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            f2.ShowDialog();
        }

        private void buttonAddJudge_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            UserControlAddJudge uc = new UserControlAddJudge();
            f2.panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            f2.ShowDialog();
        }

        private void buttonAddCountry_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            UserControlAddCountry uc = new UserControlAddCountry();
            f2.panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            f2.ShowDialog();
        }

        private void buttonManageCouple_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            UserControlManageCompetition uc = new UserControlManageCompetition();
            f3.panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            f3.ShowDialog();
        }

        private void buttonManageCompetition_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            UserControlManageCompetition uc = new UserControlManageCompetition();
            f3.panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            f3.ShowDialog();
        }
    }
}
