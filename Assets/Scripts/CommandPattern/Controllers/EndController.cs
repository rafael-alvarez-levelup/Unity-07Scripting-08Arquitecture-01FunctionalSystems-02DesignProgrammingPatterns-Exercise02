using UnityEngine;
using UnityEngine.UI;

public class EndController : MonoBehaviour
{
    private Button button;
    private IExecuteCommands commandManager;

    // TODO: Change to IProcessCommands
    private PlayerProcessor playerProcessor;
    private EnemyProcessor enemyProcessor;

    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(() => ResolveTurn());

        playerProcessor = FindObjectOfType<PlayerProcessor>();
        enemyProcessor = FindObjectOfType<EnemyProcessor>();
        commandManager = FindObjectOfType<CommandManager>();
    }

    private void ResolveTurn()
    {
        playerProcessor.ProcessCommands();
        enemyProcessor.ProcessCommands();

        commandManager.ExecuteCommands();

        playerProcessor.ResetActions();
        enemyProcessor.ResetActions();
    }
}