using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IceDanceApp.Entities
{
    public class Skate : Label
    {
        public Skate()
        {
            AutoSize = false;
            Width = 65;
            Height = Width;
            Paint += Skate_Paint;
        }

        private void Skate_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        protected void DrawImage(Graphics g)
        {
            Image imageFile = Image.FromFile("Images/skate.png");
            g.DrawImage(imageFile, new Rectangle(0, 0, Width, Height));
        }

        public void MoveSkate()
        {
            Left += 1;
        }

    }
}
