using UnityEngine;

public class TakeDamageBehaviour : MonoBehaviour, IDamageable
{
    public void TakeDamage(int amount)
    {
        print($"{gameObject} took {amount} damage!");
    }
}