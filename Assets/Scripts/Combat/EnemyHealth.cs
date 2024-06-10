using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health = 100f;

    // Method to reduce health
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
    }

    // Method to handle the enemy's death
    void Die()
    {
        // Add any death logic here, like playing an animation or destroying the game object
        Destroy(gameObject);
    }
}
