using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public float health, maxHealth;
    [SerializeField] private Health healthBar;
    public void TakeDamage()
    {
        health -= 0.1f;
        healthBar.UpdateHealthBar();
    }

    private void Start()
    {
        maxHealth = 1f;
        health = maxHealth;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player hit by " + other.tag);
        if (other.tag == "Enemy")
        {
            
            TakeDamage();
            
        }
    }
}
