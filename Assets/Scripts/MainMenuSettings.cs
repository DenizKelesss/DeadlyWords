using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuSettings : MonoBehaviour
{
    public GameObject Settings;
    public TextMeshProUGUI percentage;
    public float health;
    public static bool isNewGame = false; // Add this flag

    public void NewGame()
    {
        SaveSystem.ClearSaveData(); // Clear any existing save data
        isNewGame = true; // Set the flag to true
        SceneManager.LoadScene("Level1");
    }

    public void StartGame()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        SceneManager.LoadScene(data.sceneName);
    }

    public void OpenSettings()
    {
        Settings.SetActive(true);
    }

    public void ExitSettings()
    {
        Settings.SetActive(false);
    }

    public void LoadGame()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        if (data != null)
        {
            Debug.Log("Loading game. Saved scene: " + data.sceneName);
            SceneManager.LoadScene(data.sceneName);
        }
        else
        {
            Debug.LogError("No saved game to load.");
        }
    }

    public void OpenMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}