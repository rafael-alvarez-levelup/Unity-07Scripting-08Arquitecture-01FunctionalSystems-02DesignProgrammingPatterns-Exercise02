using UnityEngine;

public class EnemyProcessor : ProcessorBase
{
    [SerializeField] private EnemySlotBehaviour[] slots;

    private IProcessEnemyCommand commandProcessor;

    protected override void Awake()
    {
        base.Awake();

        commandProcessor = FindObjectOfType<CommandManager>();
    }

    public override void ProcessCommands()
    {
        foreach (var slot in slots)
        {
            // TODO: Needs a better place to be called.
            slot.ChangeAction();

            ICommand command = slot.CurrentAction.Action switch
            {
                Action.Default => new DefaultCommand(defaulter),
                Action.Attack => new AttackCommand(attacker),
                Action.Defend => new DefendCommand(defender),
                Action.Heal => new HealCommand(healer),
                _ => null,
            };
            commandProcessor.ProcessEnemyCommand(command);
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