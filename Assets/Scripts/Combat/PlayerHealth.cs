using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health = 100f;
    public GameObject player;
    public GameObject respawnPoint;

    // Method to reduce health
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
    }

    // Method to handle the player's death
    void Die()
    {
        // Add any death logic here, like respawning or ending the game
        Debug.Log("Player Died");
        player.transform.position = respawnPoint.transform.position;
        health = 100f; // Reset health on respawn, if desired
    }

    // Method to save health
    public void SaveHealth()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        if (data != null)
        {
            data.health = this.health;
            SaveSystem.SavePlayer(player.GetComponent<Player>());
        }
    }

    // Method to load health
    public void LoadHealth()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        if (data != null)
        {
            this.health = data.health;
        }
    }
}
