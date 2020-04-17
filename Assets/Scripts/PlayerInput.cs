using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This class registers the player's input
 * Return appropriate values based on specific inputs
 */
public class PlayerInput : MonoBehaviour
{
    // directional input variables
    [HideInInspector]public float xDirection, zDirection;

    void Update()
    {
        ProcessDirection();
    }

    /*
     * Process the player directional inputs and update the values
     */
    void ProcessDirection()
    {
        xDirection = Input.GetAxisRaw("Horizontal");
        zDirection = Input.GetAxisRaw("Vertical");
    }
}
