using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    [SerializeField] public float health, maxHealth;
    [SerializeField] private Health healthBar;
    public void TakeDamage()
    {
        // Use your own damage handling code, or this example one.
        health -= 0.1f;
        healthBar.UpdateHealthBar();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            TakeDamage();
        }
    }

    private void Start()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    TakeDamage();
        //}
        maxHealth = 1f;
        health = maxHealth;
        TakeDamage();

    }
}
