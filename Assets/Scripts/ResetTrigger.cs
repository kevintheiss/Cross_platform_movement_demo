using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetTrigger : MonoBehaviour
{
    private GameManager gameManager;

    // Start is called before the first frame update
    void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            gameManager.ResetLevel();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
