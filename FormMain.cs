using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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


        private void Run()
        {
            if (rtxtCode.Text != string.Empty)
            {
                btnRun.Enabled = false;
                btnClear.Enabled = false;
                btnClearArena.Enabled = false;
                this.rtxtCode.Text = this.rtxtCode.Text.ToUpper();
                Application.DoEvents();
                CodeManager.RunCode(rtxtCode);
                btnRun.Enabled = true;
                btnClear.Enabled = true;
                btnClearArena.Enabled = true;
            }
        }
        private void ClearCode()
        {
            this.rtxtCode.Clear();
            CodeManager = new CodeManager(this.drawer, rtxtLogShower);
        }
        private void ClearArena()
        {
            DrawedPointsTable.ClearArena(Graphics);
            DrawedPointsTable = new DrawedPointsTable(1200, 1200, 20, 20);
            drawer.InitializeDrawer(pnlArena, DrawedPointsTable, 20, 20, 1200, 1200);
            drawer.Top = 0;
            drawer.Left = 0;
        }
        private void ShowAvailableComands()
        {
            FormCommands form = new FormCommands();
            form.ShowDialog();
        }
        private void ShowAbout()
        {
            FormAbout form = new FormAbout();
            form.ShowDialog();
        }
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
            CodeManager = new CodeManager(this.drawer , this.rtxtLogShower);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Run();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearCode();
        }

        private void btnClearArena_Click(object sender, EventArgs e)
        {
            ClearArena();   
        }

        private void mnuAvailableCommands_Click(object sender, EventArgs e)
        {
            ShowAvailableComands();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            ShowAbout();
        }

        private void mnuOpenFile_Click(object sender, EventArgs e)
        {
            if(openDialog.ShowDialog() == DialogResult.OK )
            {
                string fileText = null;
                try
                {
                    fileText = File.ReadAllText(openDialog.FileName);
                    ClearArena();
                    ClearCode();
                    rtxtCode.Text = fileText;
                }
                catch(Exception ex)
                {
                    rtxtLogShower.Text = ex.Message.ToString();
                }
            }
        }

        private void mnuSaveFile_Click(object sender, EventArgs e)
        {
            if (rtxtCode.Text != string.Empty)
            {
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.AppendAllText(saveDialog.FileName, rtxtCode.Text);                        
                    }
                    catch (Exception ex)
                    {
                        rtxtLogShower.Text = ex.Message.ToString();
                    }
                }
            }
        }
    }
}
