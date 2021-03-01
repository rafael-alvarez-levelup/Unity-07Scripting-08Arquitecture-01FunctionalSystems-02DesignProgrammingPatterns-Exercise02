public class HealCommand : ICommand
{
    private readonly IHealable healer;

    public HealCommand(IHealable healer)
    {
        this.healer = healer;
    }

    public void Execute()
    {
        healer.Heal();
    }
}