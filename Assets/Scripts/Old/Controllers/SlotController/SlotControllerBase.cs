using UnityEngine;
using UnityEngine.UI;

namespace Old
{
    public class SlotControllerBase : MonoBehaviour
    {
        public ICommand Command => command;

        protected GameObject myAgent;
        protected GameObject targetAgent;
        protected ActionBase[] actions;
        protected int index;

        private Image iconImage;
        private ICommand command;
        private IAttack attacker;
        private IDamageable target;
        private IDefendable defender;
        private IHealable healer;
        private IDefaultable defaulter;

        protected virtual void Awake()
        {
            iconImage = transform.GetChild(0).GetComponent<Image>();

            attacker = myAgent.GetComponent<IAttack>();
            defender = myAgent.GetComponent<IDefendable>();
            healer = myAgent.GetComponent<IHealable>();
            defaulter = myAgent.GetComponent<IDefaultable>();

            target = targetAgent.GetComponent<IDamageable>();

            actions = new ActionBase[]
            {
            new DefaultAction(defaulter), new AttackAction(attacker, target), new DefendAction(defender), new HealAction(healer)
            };
        }

        private void Start()
        {
            ResetAction();
        }

        public void ResetAction()
        {
            ChangeAction(0);
            index = 0;
        }

        protected void ChangeAction(int index)
        {
            iconImage.sprite = actions[index].Sprite;
            command = actions[index].Command;
        }
    }
}