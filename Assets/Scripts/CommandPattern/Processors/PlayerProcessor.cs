using UnityEngine;

// TODO

public abstract class ProcessorBase : MonoBehaviour, IProcessCommands
{
    public abstract void ProcessCommands();
}

public class PlayerProcessor : MonoBehaviour, IProcessCommands
{
    [SerializeField] private SlotBehaviour[] slots;

    private IProcessPlayerCommand commandProcessor;
    private IDefaultable defaulter;
    private IAttack attacker;
    private IDefendable defender;
    private IHealable healer;

    private void Awake()
    {
        commandProcessor = FindObjectOfType<CommandManager>();

        defaulter = GetComponent<IDefaultable>();
        attacker = GetComponent<IAttack>();
        defender = GetComponent<IDefendable>();
        healer = GetComponent<IHealable>();
    }

    public void ProcessCommands()
    {
        foreach (var slot in slots)
        {
            ICommand command = slot.CurrentAction.Action switch
            {
                Action.Default => new DefaultCommand(defaulter),
                Action.Attack => new AttackCommand(attacker),
                Action.Defend => new DefendCommand(defender),
                Action.Heal => new HealCommand(healer),
                _ => null,
            };
            commandProcessor.ProcessPlayerCommand(command);
        }
    }
}