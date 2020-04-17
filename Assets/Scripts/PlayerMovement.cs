using System.Collections;
using System.Collections.Generic;
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

        if(xMove != 0f && zMove != 0f)
        {
            rigidBody.velocity = new Vector3(xMove * playerAttributes.speed, 0f, zMove * playerAttributes.speed);
        }

        if(xMove != 0f && zMove == 0f)
        {
            rigidBody.velocity = new Vector3(xMove * playerAttributes.speed, 0f, 0f);
        }

        if (xMove == 0f && zMove != 0f)
        {
            rigidBody.velocity = new Vector3(0f, 0f, zMove * playerAttributes.speed);
        }
    }
}
