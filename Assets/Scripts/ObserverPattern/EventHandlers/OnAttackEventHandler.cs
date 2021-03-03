using UnityEngine;

public class OnAttackEventHandler : MonoBehaviour, IObserver<int>
{
    private ISubject<int> AttackSubject => attackSubject;

    [SerializeField] private AttackBehaviour attackSubject;

    private void OnEnable()
    {
        AttackSubject.AddObserver(this);
    }

    private void OnDisable()
    {
        AttackSubject.RemoveObserver(this);
    }

    public void OnNotify(int parameter)
    {
        print($"{gameObject} receives {parameter} damage!");
    }
}