using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace CodePainterApp
{
    public static class Colors
    {
        public static Color GetColor(string color)
        {
            Color newColor = Color.White;
            switch(color)
            {
                case "WHITE":
                    newColor = Color.White;
                    break;
                case "YELLOW":
                    newColor = Color.Yellow;
                    break;
                case "RED":
                    newColor = Color.Red;
                    break;
                case "BLUE":
                    newColor = Color.Blue;
                    break;
            }
            return newColor;
        }
    }
}
