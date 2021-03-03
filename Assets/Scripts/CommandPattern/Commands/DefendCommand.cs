public class DefendCommand : ICommand
{
    private readonly IDefendable defender;

    public DefendCommand(IDefendable defender)
    {
        this.defender = defender;
    }

    public void Execute()
    {
        defender.Defend();
    }
}