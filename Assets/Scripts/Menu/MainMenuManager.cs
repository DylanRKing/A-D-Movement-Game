using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartGame()
    {
        // Logic to start the game
        Debug.Log("Starting Game...");
        // Load the game scene or perform any necessary setup
    }

    public void ExitGame()
    {
        // Logic to exit the game
        Debug.Log("Exiting Game...");
        Application.Quit();

        // If running in the editor, stop playing
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
