using UnityEngine;
using UnityEngine.UI;

namespace Old
{
    public class EndButtonController : MonoBehaviour, IResolveTurnEventHandler
    {
        public event IResolveTurnEventHandler.ResolveTurnEventHandler OnResolveTurn;

        [SerializeField] private SlotControllerBase[] slots;

        private Button button;
        private ICommandProcessor processor;

        private void Awake()
        {
            button = GetComponent<Button>();
            button.onClick.AddListener(() => ResolveTurn());

            processor = FindObjectOfType<CommandManager>();
        }

        private void ResolveTurn()
        {
            if (OnResolveTurn != null)
            {
                OnResolveTurn.Invoke();
            }

            foreach (SlotControllerBase slot in slots)
            {
                processor.Process(slot.Command);
                slot.ResetAction();
            }

            processor.ExecuteCommands();
        }
    }
}