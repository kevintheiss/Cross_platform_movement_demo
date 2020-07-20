using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * This class stores the global game variables and executes all global game functions
 * It is attached to an object in the pre-load scene
 */
public class GameManager : MonoBehaviour
{
    // next and current scene variables
    public Scene nextScene;
    [HideInInspector] public Scene currentScene;

    /*
     * Initialization
     */
    void Awake()
    {
        DontDestroyOnLoad(gameObject); // keep game manager persistent in all scenes
        LoadNextLevel(); // load the first scene of the game
    }

    /*
     * Update is called once per frame
     */
    void Update()
    {
        ManualReset();
    }

    /*
     * Load the next level
     */
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(nextScene.handle); // load the next scene based on its handle
    }

    /*
     * Reset the current level
     */
    public void ResetLevel()
    {
        currentScene = SceneManager.GetActiveScene(); // assign the active scene
        SceneManager.LoadScene(currentScene.name); // load the current scene based on its name
    }

    /*
     * Manually reset the current level by user input
     */
    void ManualReset()
    {
        // if the reset button is pressed...
        if(Input.GetButtonDown("Reset"))
        {
            ResetLevel(); // reset the level
        }
    }
}
