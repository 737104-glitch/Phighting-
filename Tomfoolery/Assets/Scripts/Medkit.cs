using UnityEngine;

public class Medkit : MonoBehaviour
{

    public int maxHealth = 350;
    public int currentHealth;
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = 350;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }

        if (Input.GetKeyDown(KeyCode.E))
            {
            currentHealth += 100;
            }

        if (currentHealth > maxHealth)
            {
            currentHealth = maxHealth;
            }
    }
}
