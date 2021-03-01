using UnityEngine;

public class AttackBehaviour : MonoBehaviour, IAttack
{
    [SerializeField] private int damage = 10;

    public void Attack(IDamageable target)
    {
        print($"{gameObject} attacks {target}!");

        target.TakeDamage(damage);
    }
}