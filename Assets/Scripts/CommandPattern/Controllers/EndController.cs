using UnityEngine;
using UnityEngine.UI;

// TODO

public class EndController : MonoBehaviour
{
    private Button button;
    private IProcessCommands playerProcessor;
    // private IProcessCommands enemyProcessor;
    private IExecuteCommands commandManager;

    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(() => ResolveTurn());

        playerProcessor = FindObjectOfType<PlayerProcessor>();
        // enemyProcessor = FindObjectOfType<EnemyProcessor>();
        commandManager = FindObjectOfType<CommandManager>();
    }

    private void ResolveTurn()
    {
        playerProcessor.ProcessCommands();
        // enemyProcessor.ProcessCommands();

        commandManager.ExecuteCommands();
    }
}