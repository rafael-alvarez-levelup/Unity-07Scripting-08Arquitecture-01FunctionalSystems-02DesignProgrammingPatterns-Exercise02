using UnityEngine;
using UnityEngine.UI;

// TODO: finish

public class LevelManager : MonoBehaviour, IObserver
{
    [SerializeField] private Text levelText;

    private int level = 1;

    public void OnNotify()
    {
        // Get called when an enemy dies

        level++;

        levelText.text = level.ToString();
    }
}