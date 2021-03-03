using UnityEngine;

public class DefaultBehaviour : MonoBehaviour, IDefaultable
{
    public void Default()
    {
        print($"{gameObject} does nothing.");
    }
}