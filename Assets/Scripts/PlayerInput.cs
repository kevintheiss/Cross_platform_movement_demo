using UnityEngine;

/*
 * This class registers the player's input
 * Return appropriate values based on specific inputs
 */
public class PlayerInput : MonoBehaviour
{
    // directional input variables
    [HideInInspector] public float horizontal, vertical;

    // rotation vector
    [HideInInspector] public Vector3 rotation = Vector3.zero;

    // jump input
    [HideInInspector] public bool jump;

    void Update()
    {
        ProcessMovement();
        //ProcessRotation();
    }

    /*
     * Process the player directional inputs and update the values
     */
    void ProcessMovement()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        jump = Input.GetButtonDown("Jump");
    }

    /*
     * Process the player mouse rotation inputs and update the values
     */
    void ProcessRotation()
    {
        rotation.y += Input.GetAxisRaw("Mouse X");
        rotation.x += -Input.GetAxisRaw("Mouse Y");
    }
}
