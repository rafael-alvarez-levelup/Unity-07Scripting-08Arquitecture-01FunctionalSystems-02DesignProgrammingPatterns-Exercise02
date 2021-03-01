using UnityEngine;
using UnityEngine.UI;

public class SlotController : MonoBehaviour
{
    private Button button;
    private SlotBehaviour slotBehaviour;

    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(() => OnClick());

        slotBehaviour = GetComponent<SlotBehaviour>();
    }

    private void OnClick()
    {
        slotBehaviour.ChangeAction();
    }
}