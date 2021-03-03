using UnityEngine;

public enum Action
{
    Default,
    Attack,
    Defend,
    Heal
}

[CreateAssetMenu(fileName = "NewAction", menuName = "ScriptableObject/Action")]
public class ActionData : ScriptableObject
{
    public Sprite Sprite => sprite;
    public Action Action => action;
    public int ActionPoints => actionPoints;

    [SerializeField] private Sprite sprite;
    [SerializeField] private Action action;
    [SerializeField] private int actionPoints;
}