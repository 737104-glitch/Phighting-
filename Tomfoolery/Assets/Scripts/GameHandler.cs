using UnityEngine;

public class GameHandler : MonoBehaviour
{
   private void Start()
    {
        HealthSystem healthSystem = new HealthSystem(100);

        Debug.Log("Health: " + healthSystem.GetHealth());
        healthSystem.Damage(10);
        Debug.Log("Health: " + healthSystem.GetHealth());
        healthSystem.Heal(10);
        Debug.Log("Health: " + healthSystem.GetHealth());

        
    }

    private void Update()
    {
       
    }

}
