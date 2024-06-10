using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIChase : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public float damage = 10f; // Amount of damage the enemy deals to the player

    private float distance;

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;

        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
    }

    // Detect collisions with the player
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collided object is the player
        if (collision.gameObject == player)
        {
            // Get the PlayerHealth component from the player
            Player playerHealth = player.GetComponent<Player>();
            if (playerHealth != null)
            {
                // Apply damage to the player
                playerHealth.TakeDamage(damage);
            }
        }
    }
}
