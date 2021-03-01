using System.Collections.Generic;
using UnityEngine;

public class CommandProcessor : MonoBehaviour
{
    public Queue<ICommand> PlayerCommands { get => playerCommands; }
    public Queue<ICommand> EnemyCommands { get => enemyCommands; }

    private readonly Queue<ICommand> playerCommands = new Queue<ICommand>();
    private readonly Queue<ICommand> enemyCommands = new Queue<ICommand>();

    public void ProcessPlayerCommand(ICommand command)
    {
        playerCommands.Enqueue(command);
    }

    public void ProcessEnemyCommand(ICommand command)
    {
        enemyCommands.Enqueue(command);
    }
}