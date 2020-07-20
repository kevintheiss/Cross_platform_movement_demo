using UnityEngine;

/*
 * This class registers the player's input
 * Return appropriate values based on specific inputs
 */
public class PlayerInput : MonoBehaviour
{
    // directional input variables
    [HideInInspector] public float horizontal, vertical;

    // jump input
    [HideInInspector] public bool jump;

    /*
     * Update is called once per frame
     */
    void Update()
    {
        ProcessMovement();
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
}
