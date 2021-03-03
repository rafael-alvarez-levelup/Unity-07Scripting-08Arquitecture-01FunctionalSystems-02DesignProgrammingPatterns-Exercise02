using System.Collections.Generic;
using UnityEngine;

public class HealBehaviour : MonoBehaviour, IHealable, ISubject<int>
{
    [SerializeField] private int healing = 10;

    private readonly List<IObserver<int>> observers = new List<IObserver<int>>();

    public void Heal()
    {
        print($"{gameObject} heals!");

        Notify();
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
            observer.OnNotify(healing);
        }
    }
}