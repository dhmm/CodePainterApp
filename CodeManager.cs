using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodePainterApp
{
    public class CodeManager
    {
        public int ErrorLine = -1;
        public string Error = "";

        Drawer Drawer = null;

        bool RepeatCommandActive = false;
        Dictionary<int, Command> RepeatCommands = null;
        int RepeatCount = -1;

        public CodeManager(Drawer drawer)
        {
            Drawer = drawer;
        }
        public void RunCode(string codeLines)
        {
            ErrorLine = -1;
            Error = "";

            string[] lines = codeLines.Split();

            int codeLine = 1;
            foreach(string line in lines)
            {
                try
                {
                    ExecuteLine(line);
                }
                catch(Exception exc)
                {
                    ErrorLine = codeLine;
                    Error = exc.Message.ToString();
                    return;
                }
                codeLine++;
            }
        }

        private void ExecuteLine(string line)
        {
            Command command = ReadCommandLine(line);
            if (RepeatCommandActive == false)
            {
                this.ExecuteCommand(command);
            } 
            else
            {
                if (command.CommandType != CommandType.ENDREPEAT)
                {
                    int key = RepeatCommands.Count() + 1;
                    RepeatCommands.Add(key, command);
                }
                else
                { 
                    for(int repeat=1;repeat<=RepeatCount;repeat++)
                    {
                        for (int repeatCodeLine = 1; repeatCodeLine <= RepeatCommands.Count(); repeatCodeLine++)
                        {
                            this.ExecuteCommand(RepeatCommands[repeatCodeLine]);
                        }
                    }
                    RepeatCommandActive = false;
                    RepeatCommands = null;
                    RepeatCount = -1;
                }                
            }
        }


        private void ExecuteCommand(Command command)
        {
            switch (command.CommandType)
            {
                case CommandType.GO:
                    #region GO
                    int moves = command.GetParameterAsInteger();
                    if (moves == 0)
                    {
                        moves = 1;
                    }
                    for (int i = 0; i < moves; i++)
                    {
                        Drawer.MoveDrawer();
                    }
                    #endregion
                    break;
                case CommandType.TURN:
                    #region TURN
                    string direction = command.GetParameter();
                    switch (direction)
                    {
                        case "R":
                            Drawer.TurnRight();
                            break;
                        case "L":
                            Drawer.TurnLeft();
                            break;
                        case "U":
                            Drawer.TurnUp();
                            break;
                        case "D":
                            Drawer.TurnDown();
                            break;
                        default:
                            throw new Exception("Where I will turn ?");
                            break;

                    }
                    #endregion
                    break;
                case CommandType.COLOR:
                    #region COLOR
                    string color = command.GetParameter();
                    Drawer.ChangeColor(Colors.GetColor(color));
                    #endregion
                    break;
                case CommandType.DONTPAINT:
                    #region DONTPAINT
                    Drawer.DisableDrawing();
                    #endregion
                    break;
                case CommandType.PAINT:
                    #region PAINT
                    Drawer.EnableDrawing();
                    #endregion
                    break;
                case CommandType.REPEAT:
                    RepeatCommandActive = true;
                    RepeatCommands = new Dictionary<int, Command>();
                    RepeatCount = command.GetParameterAsInteger();
                    break;
                case CommandType.UNKNOWN:
                    #region UNKNOWN
                    throw new Exception("I cant undestand the command ");
                    #endregion
                    break;
            }
        }
        private Command ReadCommandLine(string line)
        {
            Command command = new Command();
            bool hasParanthesis = line.IndexOf("(") > -1;            
            if(hasParanthesis == true)
            {
                int indexOfLeftParanthesis = line.IndexOf("(");
                int indexOfRightParanthesis = line.IndexOf(")");
                //Command without parameter
                if ( (indexOfRightParanthesis - indexOfLeftParanthesis) == 1)
                {
                    string commandName = line.Substring(0, indexOfLeftParanthesis);
                    command.Resolve(commandName);
                }
                //Command with parameter
                else
                {
                    string commandName = line.Substring(0, indexOfLeftParanthesis);
                    string parameter = line.Substring(indexOfLeftParanthesis +1, (indexOfRightParanthesis - indexOfLeftParanthesis) -1);
                    command.Resolve(commandName , parameter);
                }
            }                        
            return command;
        }
        
    }
}
