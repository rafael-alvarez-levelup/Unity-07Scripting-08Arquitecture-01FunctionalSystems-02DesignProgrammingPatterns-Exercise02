using System.Collections.Generic;
using UnityEngine;

public class ConcreteSubject : MonoBehaviour, ISubject<EventArgs>
{
    private readonly List<IObserver<EventArgs>> observers = new List<IObserver<EventArgs>>();
    private EventArgs state = new EventArgs(0, 0);

    public void ChangeState()
    {
        state = new EventArgs(1, 1);
        Notify();
    }

    public void AddObserver(IObserver<EventArgs> observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver<EventArgs> observer)
    {
        observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in observers)
        {
            observer.OnNotify(state);
        }
    }
}