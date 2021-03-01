using System.Collections.Generic;
using UnityEngine;

public class CommandManager : MonoBehaviour, ICommandProcessor
{
    private readonly Queue<ICommand> commandQueue = new Queue<ICommand>();

    public void Process(ICommand command)
    {
        commandQueue.Enqueue(command);
    }

    public void ExecuteCommands()
    {
        while (commandQueue.Count > 0)
        {
            ICommand nextCommand = commandQueue.Dequeue();
            nextCommand.Execute();
        }
    }
}