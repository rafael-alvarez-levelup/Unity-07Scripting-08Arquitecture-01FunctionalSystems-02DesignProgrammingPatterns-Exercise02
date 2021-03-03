using System.Collections.Generic;
using UnityEngine;

public class DefendBehaviour : MonoBehaviour, IDefendable, ISubject<float>
{
    [SerializeField] private float defence = 0.5f;

    private readonly List<IObserver<float>> observers = new List<IObserver<float>>();

    public void Defend()
    {
        print($"{gameObject} defends!");

        Notify();
    }

    public void AddObserver(IObserver<float> observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver<float> observer)
    {
        observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in observers)
        {
            observer.OnNotify(defence);
        }
    }
}