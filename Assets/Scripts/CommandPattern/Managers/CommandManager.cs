using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class CommandManager : MonoBehaviour, IProcessPlayerCommand, IProcessEnemyCommand, IExecuteCommands
{
    private readonly Queue<ICommand> playerCommands = new Queue<ICommand>();
    private readonly Queue<ICommand> enemyCommands = new Queue<ICommand>();

    public void ProcessPlayerCommand(ICommand command)
    {
        Assert.IsNotNull(command);

        playerCommands.Enqueue(command);
    }

    public void ProcessEnemyCommand(ICommand command)
    {
        Assert.IsNotNull(command);

        enemyCommands.Enqueue(command);
    }

    public void ExecuteCommands()
    {
        while (enemyCommands.Count > 0)
        {
            ExecuteEnemyCommands();
            ExecutePlayerCommands();
        }
    }

    private void ExecutePlayerCommands()
    {
        ICommand command = playerCommands.Dequeue();
        command.Execute();
    }

    private void ExecuteEnemyCommands()
    {
        ICommand command = enemyCommands.Dequeue();
        command.Execute();
    }
}