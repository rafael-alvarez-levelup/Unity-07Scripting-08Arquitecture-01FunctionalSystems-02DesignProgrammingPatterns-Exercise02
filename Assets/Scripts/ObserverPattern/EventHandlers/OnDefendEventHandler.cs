using UnityEngine;

public class OnDefendEventHandler : MonoBehaviour, IObserver<float>
{
    private ISubject<float> DefendSubject => defendSubject;

    [SerializeField] private DefendBehaviour defendSubject;

    private void OnEnable()
    {
        DefendSubject.AddObserver(this);
    }

    private void OnDisable()
    {
        DefendSubject.RemoveObserver(this);
    }

    public void OnNotify(float parameter)
    {
        print($"{gameObject} now takes half damage! ({parameter})");
    }
}