using OOPAssignment.IBase;

namespace OOPAssignment.Base
{
    public class CarCommandExecutorBase
    {
        protected readonly ICarCommand CarCommand;

        public CarCommandExecutorBase(ICarCommand carCommand)
        {
            CarCommand = carCommand;
        }
    }
}
