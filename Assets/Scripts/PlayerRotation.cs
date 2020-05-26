using UnityEngine;

/*
 * This class handles player rotation based on mouse movement and gamepad directional inputs
 */
public class PlayerRotation : MonoBehaviour
{
    // player script variables
    PlayerAttributes playerAttrubutes;
    PlayerInput playerInput;

    Rigidbody rigidBody;

    // Initialization
    void Awake()
    {
        playerAttrubutes = GetComponent<PlayerAttributes>();
        playerInput = GetComponent<PlayerInput>();
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RotatePlayer();
    }

    void RotatePlayer()
    {
        rigidBody.freezeRotation = false;
        transform.eulerAngles = new Vector3(0f, playerInput.rotation.y, 0f) * playerAttrubutes.lookSpeed;
        rigidBody.freezeRotation = true;
    }
}
