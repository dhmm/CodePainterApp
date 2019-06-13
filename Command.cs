using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodePainterApp
{    
    class Command
    {
        public CommandType CommandType = CommandType.UNKNOWN;
        string Parameter = string.Empty;
                
        internal void Resolve(string commandName , string parameter = "")
        {
            switch(commandName)
            {
                case "GO":
                    this.CommandType = CommandType.GO;
                    this.Parameter = parameter;
                    break;
                case "TURN":
                    this.CommandType = CommandType.TURN;
                    this.Parameter = parameter;
                    break;
                case "COLOR":
                    this.CommandType = CommandType.COLOR;
                    this.Parameter = parameter;
                    break;
                case "DONTPAINT":
                    this.CommandType = CommandType.DONTPAINT;                    
                    break;
                case "PAINT":
                    this.CommandType = CommandType.PAINT;                    
                    break;
                case "REPEAT":
                    this.CommandType = CommandType.REPEAT;
                    this.Parameter = parameter;
                    break;
                case "ENDREPEAT":
                    this.CommandType = CommandType.ENDREPEAT;                    
                    break;
            }
        }
        internal int GetParameterAsInteger()
        {
            int paramValue = 0;
            int.TryParse(Parameter, out paramValue);
            return paramValue;
        }
        internal string GetParameter()
        {
            return Parameter;
        }
    }
}
