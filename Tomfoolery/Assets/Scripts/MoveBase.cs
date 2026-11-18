using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "Move",menuName = "Fighter/Create new more")]
public class MoveBase : MonoBehaviour
{
    [SerializeField] string mName;
    [SerializeField] int cost;

    public string Name
    {
        get { return mName; } 
    }

    public int Cost 
    { 
        get { return cost; } 
    }
}
