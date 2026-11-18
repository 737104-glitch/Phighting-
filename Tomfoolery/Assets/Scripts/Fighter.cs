using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Fighter : MonoBehaviour
{
    [SerializeField] FighterBase _base;
    
    public FighterBase Base
    {
        get { return _base; }
    }

    public int HP { get; set; }

    

    


}
