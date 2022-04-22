using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public float health, maxHealth;
    public int lives;
    public GameObject spawnPoint;
    [SerializeField] private Health healthBar;
    [SerializeField] private UIController ui;
    public void TakeDamage()
    {
        health -= 0.2f;
        healthBar.UpdateHealthBar();
        if (health <= 0)
        {
            lives--;
            ui.updateLives(lives);
            RespawnPlayer();
        }
    }

    private void Start()
    {
        maxHealth = 1f;
        health = maxHealth;
        lives = 3;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player hit by " + other.tag);
        if (other.tag == "Enemy")
        {
            
            TakeDamage();
            Destroy(other);
        }
    }

    private void RespawnPlayer()
    {
        gameObject.SetActive(false);
        health = 1.0f;
        healthBar.UpdateHealthBar();
        this.transform.position = spawnPoint.transform.position;
        gameObject.SetActive(true);
    }
}
