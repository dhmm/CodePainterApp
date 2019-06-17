using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CodePainterApp
{
    public class CodeManager
    {
        public int ErrorLine = -1;
        public string Error = "";

        Drawer Drawer = null;
        RichTextBox LogShower = null;

        bool RepeatCommandActive = false;
        Dictionary<int, Command> RepeatCommands = null;
        int RepeatCount = -1;
        bool ExecutingRepeat = true;
        int RepeatStartLine = -1;
        int RepeatErrorCodeLine = -1;

        public CodeManager(Drawer drawer , RichTextBox errorLogger)
        {
            Drawer = drawer;
            LogShower = errorLogger;
        }
        public void RunCode(RichTextBox rtxtCode)
        {
            ErrorLine = -1;
            Error = "";
            RepeatCommandActive = false;
            RepeatCommands = null;
            RepeatCount = -1;
            ExecutingRepeat = true;
            RepeatStartLine = -1;
            RepeatErrorCodeLine = -1;
            LogShower.Clear();


            string[] lines = rtxtCode.Text.Split();

            int codeLine = 1;
            foreach(string line in lines)
            {
                try
                {
                    ExecuteLine(line , codeLine);
                }
                catch(Exception exc)
                {
                    ErrorLine = codeLine;
                    Error = exc.Message.ToString();
                    if(ExecutingRepeat)
                    {
                        ErrorLine = RepeatStartLine + RepeatErrorCodeLine;
                    }
                    LogShower.Text += "Line "+ ErrorLine + " : " + Error;

                    int firstcharindex = rtxtCode.GetFirstCharIndexFromLine(ErrorLine);
                    int currentline = rtxtCode.GetLineFromCharIndex(firstcharindex);
                    string currentlinetext = rtxtCode.Lines[currentline];
                    rtxtCode.Select(firstcharindex, currentlinetext.Length);


        
                    return;
                }
                codeLine++;
            }
        }

        private void ExecuteLine(string line ,int codeLine)
        {
            Command command = ReadCommandLine(line);
            if (RepeatCommandActive == false)
            {
                this.ExecuteCommand(command , codeLine);
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
                    ExecutingRepeat = true;
                    for (int repeat=1;repeat<=RepeatCount;repeat++)
                    {                        
                        for (int repeatCodeLine = 1; repeatCodeLine <= RepeatCommands.Count(); repeatCodeLine++)
                        {
                            try
                            {
                                this.ExecuteCommand(RepeatCommands[repeatCodeLine]);
                            }
                            catch(Exception ex)
                            {
                                RepeatErrorCodeLine = repeatCodeLine;
                                throw new Exception(ex.Message);                               
                            }
                        }
                    }
                    ExecutingRepeat = false;
                    RepeatCommandActive = false;
                    RepeatCommands = null;
                    RepeatCount = -1;
                    RepeatStartLine = -1;
                }                
            }
        }


        private void ExecuteCommand(Command command , int codeLine = -1)
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
                    
                        RepeatStartLine = codeLine;
                    
                    RepeatCommands = new Dictionary<int, Command>();
                    RepeatCount = command.GetParameterAsInteger();
                    break;
                case CommandType.UNKNOWN:
                    #region UNKNOWN
                    throw new Exception("Unknown command , please see the available command list");
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
                if (indexOfRightParanthesis > -1)
                {
                    //Command without parameter
                    if ((indexOfRightParanthesis - indexOfLeftParanthesis) == 1)
                    {
                        string commandName = line.Substring(0, indexOfLeftParanthesis);
                        command.Resolve(commandName);
                    }
                    //Command with parameter
                    else
                    {
                        string commandName = line.Substring(0, indexOfLeftParanthesis);
                        string parameter = line.Substring(indexOfLeftParanthesis + 1, (indexOfRightParanthesis - indexOfLeftParanthesis) - 1);
                        command.Resolve(commandName, parameter);
                    }
                }
                else
                {
                    throw new Exception("Missing right paranthesis ");
                }
            }   
            else
            {
                throw new Exception("Wrong command. All comand must have paranthesis '()'");
            }                     
            return command;
        }
        
    }
}
