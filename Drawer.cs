using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CodePainterApp
{
    public enum DIRECTION { DOWN = 1 , RIGHT , UP , LEFT };
    public partial class Drawer : UserControl
    {
        public Panel Arena { set; get; }
        private Graphics Graphics = null;
        private DrawedPointsTable DrawedPointsTable = null;
        private int ArenaBoxWidth { set; get; }
        private int ArenaBoxHeight { set; get; }
        private int ArenaWidth { set; get; }
        private int ArenaHeight { set; get; }

        private DIRECTION Direction { set; get; }
        private int X { set; get; }
        private int Y { set; get; }        

        private bool Draw { set; get; } = true;
        private Color Color = Color.White;

        const int WIDTH = 20;
        const int HEIGHT = 5;
        const int HIGH_LOCATION = 15;
        const int LOW_LOCATION = 0;

        private void HideAllDirectionPCts()
        {
            pctDown.Hide();
            pctUp.Hide();
            pctRight.Hide();
            pctLeft.Hide();
        }
        public void TurnRight()
        {
            HideAllDirectionPCts();
            pctRight.Show();
            Direction = DIRECTION.RIGHT;
        }
        public void TurnDown()
        {
            HideAllDirectionPCts();
            pctDown.Show();
            Direction = DIRECTION.DOWN;
        }
        public void TurnLeft()
        {
            HideAllDirectionPCts();
            pctLeft.Show();
            Direction = DIRECTION.LEFT;
        }
        public void TurnUp()
        {
            HideAllDirectionPCts();
            pctUp.Show();
            Direction = DIRECTION.UP;
        }
        public void MoveDrawer()
        {
            DrawedPoint dp = null;
            switch (Direction)
            {
                case DIRECTION.DOWN:
                    int newTopDown = this.Top + 20;
                    if ((newTopDown + 20) <= ArenaHeight)
                    {
                        dp = CreateDrawedPoint();
                        if (this.Draw)
                        {
                            DrawedPointsTable[this.X, this.Y] = dp;
                        }
                        this.Top = newTopDown;
                        this.Y++;
                        
                    }
                    break;
                case DIRECTION.RIGHT:
                    int newLeftRight = this.Left + 20;
                    if ((newLeftRight + ArenaBoxWidth) <= ArenaWidth)
                    {
                        dp = CreateDrawedPoint();
                        if (this.Draw)
                        {
                            DrawedPointsTable[this.X, this.Y] = dp;
                        }
                        this.Left = newLeftRight;
                        this.X++;
                        
                    }
                    break;
                case DIRECTION.UP:
                    int newTopUp = this.Top - 20;
                    if (newTopUp >= 0)
                    {
                        dp = CreateDrawedPoint();
                        if (this.Draw)
                        {
                            DrawedPointsTable[this.X, this.Y] = dp;
                        }
                        this.Top = newTopUp;
                        this.Y--;
                        
                    }
                    break;
                case DIRECTION.LEFT:
                    int newLeftLeft = this.Left - 20;
                    if (newLeftLeft >= 0)
                    {
                        dp = CreateDrawedPoint();
                        if (this.Draw)
                        {
                            DrawedPointsTable[this.X, this.Y] = dp;
                        }
                        this.Left = newLeftLeft;
                        this.X--;
                    }
                    break;
            }
            if (dp != null)
            {
                if (this.Draw)
                {
                    dp.Draw(Graphics);                    
                    Application.DoEvents();
                }
            }            
        }

        public void EnableDrawing()
        {
            Draw = true;
        }
        public void DisableDrawing()
        {
            Draw = false;
        }
        public void ChangeColor(Color color)
        {
            this.Color = color;
        }
        private DrawedPoint CreateDrawedPoint()
        {            
            return new DrawedPoint(new Point(this.Left +1, this.Top+1), this.Color, new Size(this.ArenaBoxWidth-1, this.ArenaBoxHeight-1));
        }
       
        public Drawer()
        {
            InitializeComponent();
            Direction = DIRECTION.DOWN;
        }

        public void InitializeDrawer(Panel arena , DrawedPointsTable drawedPointsTable, int arenaBoxWidth, int arenaBoxHeight, int arenaWidth,int arenaHeight)
        {
            Arena = arena;
            Graphics = arena.CreateGraphics();
            DrawedPointsTable = drawedPointsTable;
            ArenaBoxWidth = arenaBoxWidth;
            ArenaBoxHeight= arenaBoxHeight;
            ArenaWidth = arenaWidth;
            ArenaHeight = arenaHeight;
        }
    }
}
