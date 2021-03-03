using UnityEngine;
using UnityEngine.UI;

//TODO: Refactor

public abstract class SlotBehaviourBase : MonoBehaviour, IChangeAction
{
    public ActionData CurrentAction => currentAction;

    [SerializeField] protected ActionData[] actions;

    [SerializeField] private Image icon;

    protected int index;

    private ActionData currentAction;

    private void Awake()
    {
        currentAction = actions[index];
        UpdateIcon();
    }

    public virtual void ChangeAction()
    {
        ChangeIndex();
        currentAction = actions[index];
        UpdateIcon();
    }

    public virtual void ResetAction()
    {
        index = 0;
        currentAction = actions[index];
        UpdateIcon();
    }

    protected abstract void ChangeIndex();

    private void UpdateIcon()
    {
        icon.sprite = currentAction.Sprite;
    }
}