using UnityEngine;

public class OnHealEventHandler : MonoBehaviour, IObserver<int>
{
    private ISubject<int> HealSubject => healSubject;

    [SerializeField] private HealBehaviour healSubject;

    private void OnEnable()
    {
        HealSubject.AddObserver(this);
    }

    private void OnDisable()
    {
        HealSubject.RemoveObserver(this);
    }

    public void OnNotify(int parameter)
    {
        print($"{gameObject} heals for {parameter}!");
    }
}