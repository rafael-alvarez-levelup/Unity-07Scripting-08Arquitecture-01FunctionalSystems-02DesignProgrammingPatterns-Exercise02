using UnityEngine;

public class PlayerProcessor : ProcessorBase
{
    [SerializeField] private PlayerSlotBehaviour[] slots;

    private IProcessPlayerCommand commandProcessor;

    protected override void Awake()
    {
        base.Awake();

        commandProcessor = FindObjectOfType<CommandManager>();
    }

    public override void ProcessCommands()
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

    public void ResetActions()
    {
        foreach (var slot in slots)
        {
            slot.ResetAction();
        }
    }
}