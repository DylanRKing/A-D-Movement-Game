using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField]
    private string sceneToLoad = "GameScene"; // The name of the scene to load when starting the game

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        // Logic to start the game
        Debug.Log("Starting Game...");
        // Load the game scene or perform any necessary setup
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneToLoad); // Replace "GameScene" with your actual game scene name
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
