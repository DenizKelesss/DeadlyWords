using UnityEngine;
using UnityEngine.UI;

public class HealthCounter : MonoBehaviour
{
    public Text healthText;
    public Player playerHealth;

    void Update()
    {
        if (playerHealth != null)
        {
            // Calculate health percentage directly
            float healthPercentage = (playerHealth.health / 100f) * 100f;

            // Update the UI Text with the health percentage
            healthText.text = "HP: " + Mathf.RoundToInt(healthPercentage) + "%";
        }
    }
}
