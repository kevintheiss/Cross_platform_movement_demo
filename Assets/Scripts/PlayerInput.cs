using UnityEngine;

/*
 * This class registers the player's input
 * Return appropriate values based on specific inputs
 */
public class PlayerInput : MonoBehaviour
{
    // directional input variables
    [HideInInspector] public float xDirection, zDirection;

    // rotation input variables
    [HideInInspector] public float xRotation, yRotation;

    void Update()
    {
        ProcessDirection();
        ProcessRotation();
    }

    /*
     * Process the player directional inputs and update the values
     */
    void ProcessDirection()
    {
        xDirection = Input.GetAxisRaw("Horizontal");
        zDirection = Input.GetAxisRaw("Vertical");
    }

    /*
     * Process the player mouse rotation inputs and update the values
     */
    void ProcessRotation()
    {
        yRotation += Input.GetAxisRaw("Mouse X");
        xRotation += -Input.GetAxisRaw("Mouse Y");
    }
}
