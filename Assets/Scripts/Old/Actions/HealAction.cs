using UnityEngine;

namespace Old
{
    public class HealAction : ActionBase
    {
        public HealAction(IHealable healer)
        {
            sprite = Resources.Load<Sprite>("heal_normal");
            command = new HealCommand(healer);
        }
    }
}