using UnityEngine;

/*
 * This class handles player movement based on directional inputs
 */

public class PlayerMovement : MonoBehaviour
{
    // player script variables
    private PlayerAttributes playerAttributes;
    private PlayerInput playerInput;

    private Vector3 moveDirection;
    public float gravityScale = 1f;

    //Rigidbody rigidBody;

    public CharacterController controller;

    [SerializeField] Transform cam;
    [SerializeField] float turnSmoothTime = 0.1f;

    float turnSmoothVelocity;

    // Initialization
    void Awake()
    {
        playerAttributes = GetComponent<PlayerAttributes>();
        playerInput = GetComponent<PlayerInput>();
        //rigidBody = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        RotatePlayer();
    }

    /*
     * Move the player based on directional inputs
     */
    void MovePlayer()
    {
        moveDirection = new Vector3(playerInput.horizontal * playerAttributes.moveSpeed, moveDirection.y, playerInput.vertical * playerAttributes.moveSpeed);

        if(controller.isGrounded && playerInput.jump)
        {
            moveDirection.y = playerAttributes.jumpForce;
        }

        moveDirection.y = moveDirection.y + (Physics.gravity.y * gravityScale * Time.deltaTime);
        controller.Move(moveDirection * Time.deltaTime);

        // horizontal and forward movement over time
        /*float xMove = playerInput.horizontal * Time.fixedDeltaTime;
        float zMove = playerInput.vertical * Time.fixedDeltaTime;

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
        }*/
    }

    void RotatePlayer()
    {
        Vector3 lookDirection = new Vector3(playerInput.horizontal, 0f, playerInput.vertical).normalized;

        float targetAngle = Mathf.Atan2(lookDirection.x, lookDirection.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
        float smoothAngle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);

        if(lookDirection.magnitude >= 0.1f)
        {
            transform.rotation = Quaternion.Euler(0f, smoothAngle, 0f);
        }
    }
}
