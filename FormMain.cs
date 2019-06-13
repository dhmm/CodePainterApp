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
        DrawedPointsTable DrawedPointsTable = null;
        Graphics Graphics = null;
        CodeManager CodeManager = null;

        public FormMain()
        {
            InitializeComponent();
        }

     

        private void pnlArena_Paint(object sender, PaintEventArgs e)
        {            
            Pen p = new Pen(Color.FromArgb(250, 40, 40, 40));           
            for (int i = 0; i <= pnlArena.Width; i += 20)
            {
                Graphics.DrawLine(p, i, 0, i, this.pnlArena.Height);
            }
            for (int i = 0; i <= pnlArena.Height; i += 20)
            {
                Graphics.DrawLine(p, 0, i, this.pnlArena.Width, i);
            }            
            DrawedPointsTable.ReDraw(Graphics);
        }

     

        private void FormMain_Load(object sender, EventArgs e)
        {            
            this.Graphics  = pnlArena.CreateGraphics();
            DrawedPointsTable = new DrawedPointsTable(1200,1200, 20, 20);
            drawer.InitializeDrawer(pnlArena, DrawedPointsTable, 20, 20, 1200, 1200);
            CodeManager = new CodeManager(this.drawer);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            this.rtxtCode.Text = this.rtxtCode.Text.ToUpper();
            Application.DoEvents();
            CodeManager.RunCode(rtxtCode.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
