using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace CodePainterApp
{
    public class DrawedPointsTable
    {
        DrawedPoint[,] DrawedPoints = null;
        int PointsInWidth { set; get; }
        int PointsInHeight { set; get; }

        public DrawedPoint this[int x, int y]
        {
            set
            {
                if(this.DrawedPoints != null)
                {
                    DrawedPoints[x, y] = value;
                }
            }
            get
            {
                if(this.DrawedPoints != null)
                {
                    return DrawedPoints[x, y];
                }
                else
                {
                    return null;
                }
            }
        }

        internal DrawedPointsTable(int arenaWidth, int arenaHeight , int arenaBoxWidth,int arenaBoxHeight)
        {
            PointsInWidth = arenaWidth / arenaBoxWidth;
            PointsInHeight = arenaHeight / arenaBoxHeight;

            DrawedPoints = new DrawedPoint [PointsInWidth, PointsInHeight];
        }

        internal void ReDraw(Graphics g)
        {
            if (this.DrawedPoints != null)
            {
                for (int x = 0; x < PointsInWidth; x++)
                {
                    for (int y = 0; y < PointsInHeight; y++)
                    {
                        if (this[x, y] != null)
                        {
                            //this[x, y].ReDraw(g);
                            this[x, y].Draw(g);
                        }
                    }
                }
            }
        }

        internal void ClearArena(Graphics g)
        {
            if (this.DrawedPoints != null)
            {
                for (int x = 0; x < PointsInWidth; x++)
                {
                    for (int y = 0; y < PointsInHeight; y++)
                    {
                        if (this[x, y] != null)
                        {
                            //this[x, y].ReDraw(g);
                            this[x, y].Clear(g);
                        }
                    }
                }
            }
        }
    }
}
