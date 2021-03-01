public interface ICommandProcessor
{
    void Process(ICommand command);

    void ExecuteCommands();
}