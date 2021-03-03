using UnityEngine;
using UnityEngine.UI;

public class PlayerSlotController : MonoBehaviour
{
    private Button button;
    private IChangeAction actionChanger;

    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(() => OnClick());

        actionChanger = GetComponent<IChangeAction>();
    }

    private void OnClick()
    {
        actionChanger.ChangeAction();
    }
}