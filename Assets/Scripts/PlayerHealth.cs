using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public int currHealth = 0;
    public int maxHealth = 3;
   // public HealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        currHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        DamagePlayer(1);
    }

    public void DamagePlayer(int damage)
    {
        currHealth -= damage;
        //healthBar.SetHealth(currHealth);
    }
}
