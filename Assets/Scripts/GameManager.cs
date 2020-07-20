using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Scene nextScene;
    [HideInInspector] public Scene currentScene;
    //public float nextSceneIndex;


    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        LoadNextLevel();
    }

    public void LoadNextLevel()
    { 
        SceneManager.LoadScene(nextScene.handle);
    }

    public void ResetLevel()
    {
        currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }
}
