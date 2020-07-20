using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Scene nextScene;
    [HideInInspector] public Scene currentScene;

   // private bool reset;
    //public float nextSceneIndex;


    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        LoadNextLevel();
    }

    void Update()
    {
        ManualReset();
    }

    public void LoadNextLevel()
    {
        //ne = SceneManager.GetActiveScene();
        SceneManager.LoadScene(nextScene.handle);
    }

    public void ResetLevel()
    {
        currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }

    void ManualReset()
    {
        if(Input.GetButtonDown("Reset"))
        {
            ResetLevel();
        }
    }
}
