using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject medkit;
    public GameObject hyperlaser; 
    public GameObject ross; 
    public GameObject cassius;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        medkit.SetActive(true);
        hyperlaser.SetActive(true);
        ross.SetActive(true);
        cassius.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
