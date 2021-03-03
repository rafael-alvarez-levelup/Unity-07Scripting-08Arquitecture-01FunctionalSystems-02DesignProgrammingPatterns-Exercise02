using UnityEngine;

public abstract class ProcessorBase : MonoBehaviour, IProcessCommands
{
    protected IDefaultable defaulter;
    protected IAttack attacker;
    protected IDefendable defender;
    protected IHealable healer;

    protected virtual void Awake()
    {
        defaulter = GetComponent<IDefaultable>();
        attacker = GetComponent<IAttack>();
        defender = GetComponent<IDefendable>();
        healer = GetComponent<IHealable>();
    }

    public abstract void ProcessCommands();
}