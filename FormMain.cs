using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodePainterApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

     

        private void pnlArena_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = pnlArena.CreateGraphics();
            Pen p = new Pen(Color.FromArgb(250, 40, 40, 40));
            SolidBrush sb = new SolidBrush(Color.FromArgb(255, 40, 40, 40));// LightGreen);

            for (int i = 0; i <= pnlArena.Width; i += 20)
            {
                g.DrawLine(p, i, 0, i, this.pnlArena.Height);

            }
            for (int i = 0; i <= pnlArena.Height; i += 20)
            {
                g.DrawLine(p, 0, i, this.pnlArena.Width, i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = pnlArena.CreateGraphics();
            drawer.TurnDown();
            for(int i=0;i<10;i++)
            {
                if(i < 5)
                {
                    drawer.Draw = false;
                }
                else
                {
                    drawer.Draw = true;
                }

                drawer.MoveDrawer();
                
            }
            
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {            
            drawer.InitializeDrawer(pnlArena, 20, 20, 1200, 1200);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = pnlArena.CreateGraphics();

            DrawedPoint p = new DrawedPoint(new Point(0, 0), Color.White, new Size(20, 20));
            p.Draw(g);
            p = new DrawedPoint(new Point(0, 20), Color.White, new Size(20, 20));
            p.Draw(g);
            p = new DrawedPoint(new Point(0, 40), Color.White, new Size(20, 20));
            p.Draw(g);
            p = new DrawedPoint(new Point(0, 60), Color.White, new Size(20, 20));
            p.Draw(g);
            p = new DrawedPoint(new Point(0, 80), Color.White, new Size(20, 20));
            p.Draw(g);
        }
    }
}
