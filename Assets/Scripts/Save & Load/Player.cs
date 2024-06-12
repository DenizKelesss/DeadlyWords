using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float health = 100f;

    void Start()
    {
        if (MainMenuSettings.isNewGame)
        {
            health = 100f; // Ensure health is set to 100 for a new game
            MainMenuSettings.isNewGame = false; // Reset the flag after initializing the player
        }
        else
        {
            LoadHealth(); // Load health from saved data if not starting a new game
        }
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
        //SavePlayer(); // Save player state (including health and scene) immediately after taking damage
    }

    void Die()
    {
        Debug.Log("Player Died");
        health = 100f;
        SavePlayer(); // Save player state before going to main menu
        SceneManager.LoadScene("MainMenu");
    }

    public void SavePlayer()
    {
        Debug.Log("Saving Player with health: " + health + " in scene: " + SceneManager.GetActiveScene().name);
        SaveSystem.SavePlayer(this);
    }

    public void LoadHealth()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        if (data != null)
        {
            this.health = data.health;
            Debug.Log("Loaded Player with health: " + health + " from scene: " + data.sceneName);
        }
        else
        {
            Debug.Log("No saved data found. Initializing with default values.");
        }
    }
}