using System.Collections.Generic;

//TODO: Refactor

public class PlayerSlotBehaviour : SlotBehaviourBase, ISubject<int>
{
    private readonly List<IObserver<int>> observers = new List<IObserver<int>>();

    public override void ChangeAction()
    {
        Notify();

        base.ChangeAction();
    }

    public override void ResetAction()
    {
        index = -1;
        ChangeAction();
    }

    public void AddObserver(IObserver<int> observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver<int> observer)
    {
        observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in observers)
        {
            ActionData nextAction = actions[(index + 1) % actions.Length];

            observer.OnNotify(-CurrentAction.ActionPoints);
            observer.OnNotify(nextAction.ActionPoints);
        }
    }

    protected override void ChangeIndex()
    {
        index = (index + 1) % actions.Length;
    }
}