namespace OOPAssignment.IBase
{
    public interface ICommand<T> where T : class
    {
        void ExecuteCommand(T commandObject);
    }
}
