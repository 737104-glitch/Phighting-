using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Move : MonoBehaviour
{
    public MoveBase Base { get; set; }

    public int Cost { get; set; }

    public Move(MoveBase fBase)
    {
        Base = fBase;
        Cost = fBase.Cost;
    }
}
