using UnityEngine;

/*
 * This class handles player movement based on directional inputs
 */

public class PlayerMovement : MonoBehaviour
{
    // player script variables
    PlayerAttributes playerAttributes;
    PlayerInput playerInput;

    Rigidbody rigidBody;

    // Initialization
    void Awake()
    {
        playerAttributes = GetComponent<PlayerAttributes>();
        playerInput = GetComponent<PlayerInput>();
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovePlayer();
    }

    /*
     * Move the player based on directional inputs
     */
    void MovePlayer()
    {
        // horizontal and forward movement over time
        float xMove = playerInput.xDirection * Time.fixedDeltaTime;
        float zMove = playerInput.zDirection * Time.fixedDeltaTime;

        // if the player's input is diagonal, move diagonally in that direction
        if(xMove != 0f && zMove != 0f)
        {
            rigidBody.velocity = new Vector3(xMove * playerAttributes.moveSpeed, 0f, zMove * playerAttributes.moveSpeed);
        }

        // if the player's input is left or right, move in that direction
        if(xMove != 0f && zMove == 0f)
        {
            rigidBody.velocity = new Vector3(xMove * playerAttributes.moveSpeed, 0f, 0f);
        }

        // if the player's input is up or down, move forward on up input, and backward on down input
        if (xMove == 0f && zMove != 0f)
        {
            rigidBody.velocity = new Vector3(0f, 0f, zMove * playerAttributes.moveSpeed);
        }
    }
}
