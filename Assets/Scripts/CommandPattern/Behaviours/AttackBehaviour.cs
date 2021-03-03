using System.Collections.Generic;
using UnityEngine;

public class AttackBehaviour : MonoBehaviour, IAttack, ISubject<int>
{
    [SerializeField] private int damage = 10;

    private readonly List<IObserver<int>> observers = new List<IObserver<int>>();

    public void Attack()
    {
        print($"{gameObject} attacks for {damage} damage!");

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
            observer.OnNotify(damage);
        }
    }
}