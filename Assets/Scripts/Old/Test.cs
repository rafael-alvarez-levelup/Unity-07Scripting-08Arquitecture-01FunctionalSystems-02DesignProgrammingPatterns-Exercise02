using UnityEngine;

namespace Old
{
    public class Test : MonoBehaviour
    {
        private ICommandProcessor processor;
        private IAttack attacker;
        private IDamageable target;
        private IHealable healer;
        private IDefendable defender;

        private void Awake()
        {
            processor = FindObjectOfType<CommandManager>();

            attacker = GetComponent<IAttack>();
            defender = GetComponent<IDefendable>();
            healer = GetComponent<IHealable>();

            target = GameObject.Find("Enemy").GetComponent<IDamageable>();
        }

        private void Start()
        {
            ICommand attackCommand = new AttackCommand(attacker, target);
            ICommand healCommand = new HealCommand(healer);
            ICommand defendCommand = new DefendCommand(defender);

            processor.Process(attackCommand);
            processor.Process(healCommand);
            processor.Process(defendCommand);

            processor.ExecuteCommands();
        }
    }
}