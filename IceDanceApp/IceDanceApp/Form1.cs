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
using IceDanceApp.Entities;


namespace IceDanceApp
{
    public partial class Form1 : Form
    {
        Database1Entities context = new Database1Entities();

        private List<Skate> _skate = new List<Skate>();

        private SkateFactory _factory;
        public SkateFactory Factory
        {
            get { return _factory; }
            set { _factory = value; }
        }

        List<Ranking> Ranking = new List<Ranking>();

        Excel.Application xlApp;
        Excel.Workbook xlWB;
        Excel.Worksheet xlSheet;

        public Form1() 
        {
            InitializeComponent();
            coupleRankList();
            Factory = new SkateFactory();
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
            "Ranking",
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
                values[counter, 0] = counter + 1;
                values[counter, 1] = x.Name;
                values[counter, 2] = x.Point;
                counter++;
            }

            xlSheet.get_Range(GetCell(2, 1), GetCell(1 + values.GetLength(0), values.GetLength(1))).Value2 = values;

            xlSheet.get_Range(GetCell(1, 1), GetCell(1, 1)).ColumnWidth = 7;
            xlSheet.get_Range(GetCell(1, 2), GetCell(1, 2)).ColumnWidth = 15;
            xlSheet.get_Range(GetCell(1, 3), GetCell(1, 3)).ColumnWidth = 7;

            Excel.Range headerRange = xlSheet.get_Range(GetCell(1, 1), GetCell(1, headers.Length));
            headerRange.Font.Bold = true;
            headerRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            headerRange.RowHeight = 40;
            headerRange.Interior.Color = Color.FromArgb(180, 207, 250);
            headerRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);

            Excel.Range goldRange = xlSheet.get_Range(GetCell(2, 1), GetCell(2, headers.Length));
            goldRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            goldRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            goldRange.RowHeight = 30;
            goldRange.Interior.Color = Color.Gold;
            goldRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);

            Excel.Range silverRange = xlSheet.get_Range(GetCell(3, 1), GetCell(3, headers.Length));
            silverRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            silverRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            silverRange.RowHeight = 30;
            silverRange.Interior.Color = Color.Silver;
            silverRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);

            Excel.Range bronzRange = xlSheet.get_Range(GetCell(4, 1), GetCell(4, headers.Length));
            bronzRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            bronzRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            bronzRange.RowHeight = 30;
            bronzRange.Interior.Color = Color.FromArgb(205, 127, 50);
            bronzRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);

            Excel.Range bodyRange = xlSheet.get_Range(GetCell(5, 1), GetCell(counter+1, headers.Length));
            bodyRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            bodyRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; 
            bodyRange.RowHeight = 30;
            bodyRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);


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

        private void createTimer_Tick(object sender, EventArgs e)
        {
            var skate = Factory.CreateNew();
            _skate.Add(skate);
            skate.Left = -skate.Width;
            skatePanel.Controls.Add(skate);
        }

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            var maxPosition = 0;
            foreach (var skate in _skate)
            {
                skate.MoveSkate();
                if (skate.Left > maxPosition)
                    maxPosition = skate.Left;
            }

            if (maxPosition > 1000)
            {
                var oldestSkate = _skate[0];
                skatePanel.Controls.Remove(oldestSkate);
                _skate.Remove(oldestSkate);
            }

        }
    }
}
