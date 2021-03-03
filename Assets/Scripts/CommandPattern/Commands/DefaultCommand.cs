public class DefaultCommand : ICommand
{
    private readonly IDefaultable defaulter;

    public DefaultCommand(IDefaultable defaulter)
    {
        this.defaulter = defaulter;
    }

    public void Execute()
    {
        defaulter.Default();
    }
}