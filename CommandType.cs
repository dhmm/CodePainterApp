using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodePainterApp
{
    public enum CommandType
    {
        UNKNOWN = 0 ,
        GO = 1,
        TURN = 2 ,
        COLOR = 3,
        DONTPAINT= 4 ,
        PAINT = 5 , 
        REPEAT = 6 ,
        ENDREPEAT = 7
    }
}
