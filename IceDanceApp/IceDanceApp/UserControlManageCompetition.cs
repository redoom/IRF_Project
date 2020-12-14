using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IceDanceApp
{
    public partial class UserControlManageCompetition : UserControl
    {
        Database1Entities context = new Database1Entities();
        public UserControlManageCompetition()
        {   
            InitializeComponent();
            coupleListing();
            competitionListing();
            coupleCompetitionListing();
        }
        private void coupleListing()
        {
            var cp = from x in context.Couple
                      where (x.Competitor.Name.Contains(textBoxCoupleSearch.Text) || x.Competitor1.Name.Contains(textBoxCoupleSearch.Text))
                      select new
                      {
                          ID = x.CoupleSK,
                          Name = x.Competitor.Name + " - " + x.Competitor1.Name
                      };

            listBoxCouple.DataSource = cp.ToList();
            listBoxCouple.DisplayMember = "Name";
        }

        private void competitionListing()
        {
            var cm = from x in context.Competition
                     where x.Name.Contains(textBoxCompetitionSearch.Text)
                     select x;

            listBoxCompetition.DataSource = cm.ToList();
            listBoxCompetition.DisplayMember = "Name";
        }

        private void coupleCompetitionListing()
        {
            var cc = from x in context.Competition_Couple
                     where (x.Competition.Name.Contains(textBoxCoupleCompetitionSearch.Text) || x.Couple.Competitor.Name.Contains(textBoxCoupleCompetitionSearch.Text) || x.Couple.Competitor1.Name.Contains(textBoxCoupleCompetitionSearch.Text))
                     select new
                     {
                         ID = x.SeasonEventSK,
                         Competition = x.Competition.Name,
                         Couple = x.Couple.Competitor.Name + " - " + x.Couple.Competitor1.Name,
                         Rank = x.Rank
                     };
            dataGridViewCoupleCompetition.DataSource = cc.ToList();
        }

        private void textBoxCoupleSearch_TextChanged(object sender, EventArgs e)
        {
            coupleListing();
        }

        private void textBoxCompetitionSearch_TextChanged(object sender, EventArgs e)
        {
            competitionListing();
        }

        private void textBoxCoupleCompetitionSearch_TextChanged(object sender, EventArgs e)
        {
            coupleCompetitionListing();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Competition_Couple cc = new Competition_Couple();
            dynamic couple = listBoxCouple.SelectedItem;
            cc.CompetitionFK = ((Competition)listBoxCompetition.SelectedItem).CompetitionID;
            cc.CoupleFK = couple.ID;
            int rank;
            if (!int.TryParse(textBoxRank.Text, out rank)) return;
            cc.Rank = rank;
            context.Competition_Couple.Add(cc);
            context.SaveChanges();
            coupleCompetitionListing();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int rid = ((int)dataGridViewCoupleCompetition.CurrentRow.Cells[0].Value);
            var deleting = (from x in context.Competition_Couple
                            where x.SeasonEventSK == rid
                            select x).FirstOrDefault();
            context.Competition_Couple.Remove(deleting);
            context.SaveChanges();
            coupleCompetitionListing();
        }
    }
}
