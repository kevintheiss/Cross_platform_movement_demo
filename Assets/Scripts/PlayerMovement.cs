using UnityEngine;

/*
 * This class handles player movement based on directional inputs
 */
public class PlayerMovement : MonoBehaviour
{
    // player script variables
    private PlayerAttributes playerAttributes;
    private PlayerInput playerInput;

    // directional jump vector
    private Vector3 jumpVector;

    // player rigidbody
    private Rigidbody playerRigidBody;

    /* 
     * Initialization
     */
    void Awake()
    {
        playerAttributes = GetComponent<PlayerAttributes>();
        playerInput = GetComponent<PlayerInput>();
        playerRigidBody = GetComponent<Rigidbody>();
        jumpVector = new Vector3(0f, playerAttributes.jumpHeight, 0f);
    }

    /*
     * FixedUpdate is called once per frame at a fixed interval
     */
    void FixedUpdate()
    {
        PlayerMove();
    }

    /*
     * Update is called once per frame
     */
    void Update()
    {
        PlayerJump();
    }

    /*
     * Move the player based on directional inputs
     */
    void PlayerMove()
    {
        Vector3 moveVector = new Vector3(playerInput.horizontal, 0.0f, playerInput.vertical); // player directional movement vector
        transform.Translate(moveVector.normalized * playerAttributes.moveSpeed * Time.deltaTime); // move the player along the movement vector
    }

    /*
     * Make the player jump based on key/button input
     */
    void PlayerJump()
    {
        // if the jump button is pressed, and the player is not in the air...
        if(playerInput.jump && playerRigidBody.velocity.y == 0f)
        { 
            playerRigidBody.AddForce(jumpVector * playerAttributes.jumpForce, ForceMode.Impulse); // player jumps
        }
    }
}
