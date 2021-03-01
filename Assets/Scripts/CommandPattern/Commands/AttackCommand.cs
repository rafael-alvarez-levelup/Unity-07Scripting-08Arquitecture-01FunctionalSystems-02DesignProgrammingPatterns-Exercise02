public class AttackCommand : ICommand
{
    private readonly IAttack attacker;
    private readonly IDamageable target;

    public AttackCommand(IAttack attacker, IDamageable target)
    {
        this.attacker = attacker;
        this.target = target;
    }

    public void Execute()
    {
        attacker.Attack(target);
    }
}