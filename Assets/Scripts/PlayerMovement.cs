using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This class handles player movement based on input axes
 */

public class PlayerMovement : MonoBehaviour
{
    PlayerAttributes playerAttributes;
    PlayerInput playerInput;

    // Initialization
    void Awake()
    {
        playerAttributes = GetComponent<PlayerAttributes>();
        playerInput = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    /*
     * Move the player based on directional inputs
     */
    void MovePlayer()
    {
        // x position adjustment values
        float xOffset = playerInput.xThrow * playerAttributes.speed * Time.deltaTime;
        float rawXPos = transform.localPosition.x + xOffset;
    }
}
