using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace IceDanceApp
{
    public partial class Form1 : Form
    {
        Database1Entities context = new Database1Entities();

        List<Ranking> Ranking = new List<Ranking>();

        Excel.Application xlApp;
        Excel.Workbook xlWB;
        Excel.Worksheet xlSheet;

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
            Ranking = rank.OrderByDescending(x => x.Point).ThenBy(x => x.Name).ToList();
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

        private void buttonCreateExcel_Click(object sender, EventArgs e)
        {

            // Excel elindítása és az applikáció objektum betöltése
            xlApp = new Excel.Application();

            // Új munkafüzet
            xlWB = xlApp.Workbooks.Add(Missing.Value);

            // Új munkalap
            xlSheet = xlWB.ActiveSheet;

            string[] headers = new string[] {
            "Name",
            "Point",
            };

            object[,] values = new object[Ranking.Count, headers.Length];

            for (int i = 0; i < headers.Length; i++)
            {
                xlSheet.Cells[1, (i + 1)] = headers[i];
            }

            int counter = 0;
            foreach (Ranking x in Ranking)
            {
                values[counter, 0] = x.Name;
                values[counter, 1] = x.Point;
                counter++;
            }

            xlSheet.get_Range(GetCell(2, 1), GetCell(1 + values.GetLength(0), values.GetLength(1))).Value2 = values;

            xlApp.Visible = true;
            xlApp.UserControl = true;

        }

        private string GetCell(int x, int y)
        {
            string ExcelCoordinate = "";
            int dividend = y;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                ExcelCoordinate = Convert.ToChar(65 + modulo).ToString() + ExcelCoordinate;
                dividend = (int)((dividend - modulo) / 26);
            }
            ExcelCoordinate += x.ToString();

            return ExcelCoordinate;
        }
    }
}
