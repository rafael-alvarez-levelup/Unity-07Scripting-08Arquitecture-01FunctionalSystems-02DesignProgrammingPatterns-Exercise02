using UnityEngine;
using UnityEngine.UI;

namespace Old
{
    public class PlayerSlotController : SlotControllerBase
    {
        private Button button;

        protected override void Awake()
        {
            myAgent = GameObject.Find("Player");
            targetAgent = GameObject.Find("Enemy");

            button = GetComponent<Button>();
            button.onClick.AddListener(() => ChangeAction(GetIndex()));

            base.Awake();
        }

        private int GetIndex()
        {
            index = (index + 1) % actions.Length;
            return index;
        }
    }
}