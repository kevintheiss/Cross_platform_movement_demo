using TMPro;
using UnityEngine;

/*
 * This class handles player movement based on directional inputs
 */
public class PlayerMovement : MonoBehaviour
{
    public CharacterController characterController;
    public Transform cam;

    public float speed = 6f;

    public float turnSmoothTime = 0.1f;

    float turnSmoothVelocity;

    PlayerAttributes playerAttributes;

    PlayerInput playerInput;

    void Awake()
    {
        playerAttributes = GetComponent<PlayerAttributes>();
        playerInput = GetComponent<PlayerInput>();
    }

    void FixedUpdate()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        Vector3 direction = new Vector3(playerInput.xDirection, 0f, playerInput.zDirection).normalized;
        float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
        float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);

        if (direction.magnitude >= 0.1f)
        {
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            characterController.Move(moveDir.normalized * speed * Time.deltaTime);
        }
    }

    /*
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
     
    void MovePlayer()
    {
        // horizontal and forward movement over time
        float xMove = playerInput.xDirection * Time.fixedDeltaTime;
        float zMove = playerInput.zDirection * Time.fixedDeltaTime;

        // if the player's input is diagonal, move diagonally in that direction
        if(xMove != 0f && zMove != 0f)
        {
            rigidBody.velocity = new Vector3(xMove * playerAttributes.playerMoveSpeed, 0f, zMove * playerAttributes.playerMoveSpeed);
        }

        // if the player's input is left or right, move in that direction
        if(xMove != 0f && zMove == 0f)
        {
            rigidBody.velocity = new Vector3(xMove * playerAttributes.playerMoveSpeed, 0f, 0f);
        }

        // if the player's input is up or down, move forward on up input, and backward on down input
        if (xMove == 0f && zMove != 0f)
        {
            rigidBody.velocity = new Vector3(0f, 0f, zMove * playerAttributes.playerMoveSpeed);
        }
    }*/
}
