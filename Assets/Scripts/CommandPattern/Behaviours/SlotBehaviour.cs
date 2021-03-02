using UnityEngine;
using UnityEngine.UI;

// TODO

public class SlotBehaviour : MonoBehaviour, IChangeAction
{
    public ActionData CurrentAction => currentAction;

    [SerializeField] private ActionData[] actions;
    [SerializeField] private Image icon;

    private ActionData currentAction;
    private int index;

    private void Awake()
    {
        currentAction = actions[index];
        UpdateIcon();
    }

    public void ChangeAction()
    {
        index = (index + 1) % actions.Length;
        currentAction = actions[index];
        UpdateIcon();
    }

    private void UpdateIcon()
    {
        icon.sprite = currentAction.Sprite;
    }
}