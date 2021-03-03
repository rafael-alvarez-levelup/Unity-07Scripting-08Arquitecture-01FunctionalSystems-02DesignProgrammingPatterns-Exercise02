using UnityEngine;
using UnityEngine.UI;

// TODO: Refactor

public class BarActionPlayerManager : MonoBehaviour, IObserver<int>
{
    [SerializeField] private Image fillImage;
    [SerializeField] private Text labelText;
    [SerializeField] private PlayerSlotBehaviour[] slots;

    private int actionPoints = 10;

    private void OnEnable()
    {
        foreach (var slot in slots)
        {
            slot.AddObserver(this);
        }
        
    }

    private void OnDisable()
    {
        foreach (var slot in slots)
        {
            slot.AddObserver(this);
        }
    }

    public void OnNotify(int parameter)
    {
        actionPoints -= parameter;

        fillImage.fillAmount -= (float)parameter / 10;
        labelText.text = $"{actionPoints}/10";
    }
}