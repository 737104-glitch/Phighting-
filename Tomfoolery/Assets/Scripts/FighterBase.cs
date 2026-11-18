using Unity.Collections;
using UnityEngine;

public class FighterBase : ScriptableObject
{
    [SerializeField] string fName;
    [SerializeField] int maxHp;
    [SerializeField] int attack;
    [SerializeField] Sprite icon;

    public string Name
    {
        get { return fName; }
    }

    public int MaxHp
    {
        get { return maxHp; }
    }

    public int Attack
    {
        get { return attack; }
    }

    [SerializeField] MoveBase moveBase;

    public MoveBase Base
    {
        get
        {
            return moveBase;
        }
    }
}
