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
        private int ArenaBoxWidth { set; get; }
        private int ArenaBoxHeight { set; get; }
        private int ArenaWidth { set; get; }
        private int ArenaHeight { set; get; }

        public DIRECTION Direction { set; get; } = DIRECTION.DOWN;
        private int X {
            set
            {
                this.Left = value;
            }
            get
            {
                return this.Left;
            }
        }
        private int Y
        {
            set
            {
                this.Top = value;
            }
            get
            {
                return this.Top;
            }
        }

        public bool Draw = true;
        public Color Color = Color.White;

        const int WIDTH = 20;
        const int HEIGHT = 5;
        const int HIGH_LOCATION = 15;
        const int LOW_LOCATION = 0;
        public void TurnRight()
        {
            RotateVertical();
            pnlHead.Left = HIGH_LOCATION;
            pnlHead.Top = LOW_LOCATION;
            Direction = DIRECTION.RIGHT;
        }
        public void TurnDown()
        {
            RotateHorizontal();
            pnlHead.Left = LOW_LOCATION;
            pnlHead.Top = HIGH_LOCATION;
            Direction = DIRECTION.DOWN;
        }
        public void TurnLeft()
        {
            RotateVertical();
            pnlHead.Left = LOW_LOCATION;
            pnlHead.Top = LOW_LOCATION;
            Direction = DIRECTION.LEFT;
        }
        public void TurnUp()
        {
            RotateHorizontal();
            pnlHead.Left = LOW_LOCATION;
            pnlHead.Top = LOW_LOCATION;
            Direction = DIRECTION.UP;
        }
        public void MoveDrawer()
        {
            DrawedPoint dp = null;
            switch (Direction)
            {
                case DIRECTION.DOWN:
                    int newTopDown = X + 20;
                    if ((newTopDown + 20) <= ArenaHeight)
                    {
                        dp = CreateDrawedPoint();                        
                        this.Y += 20;
                        
                    }
                    break;
                case DIRECTION.RIGHT:
                    int newLeftRight = X + 20;
                    if ((newLeftRight + ArenaBoxWidth) <= ArenaWidth)
                    {
                        dp = CreateDrawedPoint();
                        this.X += 20;
                        
                    }
                    break;
                case DIRECTION.UP:
                    int newTopUp = Y - 20;
                    if (newTopUp >= 0)
                    {
                        dp = CreateDrawedPoint();                        
                        this.Y -= 20;
                        
                    }
                    break;
                case DIRECTION.LEFT:
                    int newLeftLeft = X - 20;
                    if (newLeftLeft >= 0)
                    {
                        dp = CreateDrawedPoint();                        
                        this.X -=20;                        
                    }
                    break;
            }
            if (dp != null)
            {
                if (this.Draw)
                {
                    dp.Draw(Arena.CreateGraphics());
                    Application.DoEvents();
                }
            }            
        }
        private void RotateHorizontal()
        {
            pnlHead.Width = WIDTH;
            pnlHead.Height = HEIGHT;
        }
        private void RotateVertical()
        {
            pnlHead.Width = HEIGHT;
            pnlHead.Height = WIDTH;
        }

        private DrawedPoint CreateDrawedPoint()
        {            
            return new DrawedPoint(new Point(this.X, this.Y), this.Color, new Size(this.ArenaBoxWidth, this.ArenaBoxHeight));
        }
       
        public Drawer()
        {
            InitializeComponent();
        }

        public void InitializeDrawer(Panel arena , int arenaBoxWidth, int arenaBoxHeight, int arenaWidth,int arenaHeight)
        {
            Arena = arena;
            Graphics = arena.CreateGraphics();
            ArenaBoxWidth = arenaBoxWidth;
            ArenaBoxHeight= arenaBoxHeight;
            ArenaWidth = arenaWidth;
            ArenaHeight = arenaHeight;
        }
    }
}
