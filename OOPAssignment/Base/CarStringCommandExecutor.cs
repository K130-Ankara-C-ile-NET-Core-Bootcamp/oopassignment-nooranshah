using OOPAssignment.IBase;
using System;

namespace OOPAssignment.Base
{
    public class CarStringCommandExecutor : CarCommandExecutorBase, IStringCommand
    {
        public CarStringCommandExecutor(ICarCommand CarCommand) : base(CarCommand)
        {
        }
        public void ExecuteCommand(string commandObject)
        {
            if (commandObject == null || commandObject == string.Empty)
            {
                throw new Exception();
            }
            else
            {
                foreach (char command in commandObject)
                {
                    if (command == 'M')
                    {
                        CarCommand.Move();
                    }
                    else if (command == 'R')
                    {
                        CarCommand.TurnRight();
                    }
                    else if (command == 'L')
                    {
                        CarCommand.TurnLeft();
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }


        }
    }
}
