using UnityEngine;

public class DefendBehaviour : MonoBehaviour, IDefendable
{
    public void Defend()
    {
        print($"{gameObject} defends!");
    }
}