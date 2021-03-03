using UnityEngine;

public class EnemySlotBehaviour : SlotBehaviourBase
{
    protected override void ChangeIndex()
    {
        index = Random.Range(0, actions.Length);
    }
}