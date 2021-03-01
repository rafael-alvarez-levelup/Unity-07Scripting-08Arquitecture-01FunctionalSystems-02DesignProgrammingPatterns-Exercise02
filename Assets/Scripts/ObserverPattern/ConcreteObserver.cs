using UnityEngine;

public class ConcreteObserver : MonoBehaviour, IObserver<EventArgs>
{
    private ISubject<EventArgs> concreteSubject;

    private void Awake()
    {
        concreteSubject = FindObjectOfType<ConcreteSubject>();
    }

    private void OnEnable()
    {
        concreteSubject.AddObserver(this);
    }

    private void OnDisable()
    {
        concreteSubject.RemoveObserver(this);
    }

    public void OnNotify(EventArgs state)
    {
        print($"Concrete subject state = {state}");
    }
}