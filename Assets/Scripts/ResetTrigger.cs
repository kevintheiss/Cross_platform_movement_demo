using UnityEngine;

/*
 * This class is attached to an invisible cube with a box collider under the stage
 * When the player falls off the stage and hits the collider, reset the level
 */
public class ResetTrigger : MonoBehaviour
{
    // access the game manager
    private GameManager gameManager;

    /*
     * Initialization
     */
    void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    /*
     * Check for collisions
     */
    void OnCollisionEnter(Collision other)
    {
        // if the player collides with the reset trigger...
        if(other.gameObject.tag == "Player")
        {
            gameManager.ResetLevel(); // reset the level
        }
    }
}
