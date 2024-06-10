using UnityEngine;

public class SceneInitializer : MonoBehaviour
{
    void Start()
    {
        GameObject playerObject = GameObject.FindWithTag("Player");
        if (playerObject != null)
        {
            Player player = playerObject.GetComponent<Player>();
            player.SavePlayer();
            if (player != null)
            {
                player.LoadHealth(); // Load health when the scene starts
            }
            else
            {
                Debug.LogError("Player component not found on the player object.");
            }
        }
        else
        {
            Debug.LogError("Player object not found with tag 'Player'.");
        }
    }
}