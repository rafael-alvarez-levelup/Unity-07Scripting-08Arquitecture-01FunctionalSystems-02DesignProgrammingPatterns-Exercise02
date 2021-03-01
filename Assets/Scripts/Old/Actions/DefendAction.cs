using UnityEngine;

namespace Old
{
    public class DefendAction : ActionBase
    {
        public DefendAction(IDefendable defender)
        {
            sprite = Resources.Load<Sprite>("shield_normal");
            command = new DefendCommand(defender);
        }
    }
}