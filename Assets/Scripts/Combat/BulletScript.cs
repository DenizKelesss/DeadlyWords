using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private Camera mainCam;
    private Rigidbody2D rb;
    public float force;
    public float damage = 10f; // Amount of damage the bullet deals

    // Start is called before the first frame update
    void Start()
    {
        mainCam = Camera.main;
        rb = GetComponent<Rigidbody2D>();

        // Get the mouse position in the world space
        Vector3 mousePos = mainCam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Mathf.Abs(mainCam.transform.position.z)));

        // Calculate the direction from the bullet to the mouse position
        Vector3 direction = (mousePos - transform.position).normalized;

        // Set the bullet's velocity
        rb.velocity = direction * force;

        // Calculate the angle in degrees
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Apply the rotation to the z axis
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    // Detect collisions with other objects
    void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the collided object has an EnemyHealth component
        EnemyHealth enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
        if (enemyHealth != null)
        {
            // Apply damage to the enemy
            enemyHealth.TakeDamage(damage);
        }

        // Destroy the bullet upon impact
        Destroy(gameObject);
    }
}
