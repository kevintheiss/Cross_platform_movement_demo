using UnityEngine;

/*
 * This class handles player movement based on directional inputs
 */

public class PlayerMovement : MonoBehaviour
{
    // player script variables
    private PlayerAttributes playerAttributes;
    private PlayerInput playerInput;

    //private Vector3 moveDirection;
    //public float gravityScale = 1f;

    private Vector3 jumpVector;

    Rigidbody playerRigidBody;

    //public CharacterController controller;

    //[SerializeField] Transform cam;
  //  [SerializeField] float turnSmoothTime = 0.1f;

    //float turnSmoothVelocity;

    // Initialization
    void Awake()
    {
        playerAttributes = GetComponent<PlayerAttributes>();
        playerInput = GetComponent<PlayerInput>();
        playerRigidBody = GetComponent<Rigidbody>();
        jumpVector = new Vector3(0f, playerAttributes.jumpHeight, 0f);
        //controller = GetComponent<CharacterController>();
    }

    void FixedUpdate()
    {
        PlayerMove();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerJump();
        //PlayerRotate();
    }

    /*
     * Move the player based on directional inputs
     */
    void PlayerMove()
    {
        //moveDirection = new Vector3(playerInput.horizontal * playerAttributes.moveSpeed, moveDirection.y, playerInput.vertical * playerAttributes.moveSpeed);

        //moveDirection = (transform.forward * playerInput.vertical * playerAttributes.moveSpeed) + (transform.right * playerInput.horizontal * playerAttributes.moveSpeed);
        //moveDirection = moveDirection.normalized * playerAttributes.moveSpeed;

        /*if(controller.isGrounded && moveDirection.y < 0f)
        {
            moveDirection.y = 0f;
        }

        if (playerInput.jump && controller.isGrounded)
        {
            moveDirection.y = playerAttributes.jumpForce;
        }

        moveDirection.y = moveDirection.y + (Physics.gravity.y * gravityScale * Time.deltaTime);
        controller.Move(moveDirection * Time.deltaTime);*/

        // playerRigidBody.velocity = Vector3.zero;
        

        // horizontal and forward movement over time
        //float xMove = playerInput.horizontal * Time.fixedDeltaTime;
        Vector3 moveVector = new Vector3(playerInput.horizontal, 0.0f, playerInput.vertical);
        transform.Translate(moveVector.normalized * playerAttributes.moveSpeed * Time.deltaTime);

        //moveVector.y = playerRigidBody.velocity.y;
        //playerRigidBody.velocity = moveVector;
        //float zMove = playerInput.vertical * Time.fixedDeltaTime;

        // if the player's input is diagonal, move diagonally in that direction
        /*if(playerInput.horizontal != 0f)// && zMove != 0f)
        {
            playerRigidBody.AddForce(moveVector, ForceMode.Impulse); //= new Vector3(xMove * playerAttributes.moveSpeed, 0f, 0f);
        }*/

        // if the player's input is left or right, move in that direction
        /*if(xMove != 0f && zMove == 0f)
        {
            rigidBody.velocity = new Vector3(xMove * playerAttributes.moveSpeed, 0f, 0f);
        }*/

        // if the player's input is up or down, move forward on up input, and backward on down input
        /*if (xMove == 0f )
        {
            rigidBody.velocity = new Vector3(0f, 0f, zMove * playerAttributes.moveSpeed);
        }*/
    }

    /* void OnCollisionStay()
     {
         playerAttributes.isGrounded = true;
     }*/

    /*void OnCollisionEnter()
    {
        if(playerRigidBody.velocity.y == 0f)
        {
            playerAttributes.isGrounded = true;
            //playerRigidBody.velocity = Vector3.zero;
            //playerRigidBody.angularVelocity = Vector3.zero;
        }
    }*/

    void PlayerJump()
    {
        if(playerInput.jump && playerRigidBody.velocity.y == 0f)
        {
            //playerRigidBody.velocity = new Vector3(playerRigidBody.velocity.x, 0f, playerRigidBody.velocity.z);
            playerRigidBody.AddForce(jumpVector * playerAttributes.jumpForce, ForceMode.Impulse);
            //playerAttributes.isGrounded = false;
        }
    }

    /*void PlayerRotate()
    {
        rigidBody.freezeRotation = true;

        Vector3 lookDirection = new Vector3(playerInput.horizontal, 0f, 0f).normalized;

        float targetAngle = Mathf.Atan2(lookDirection.x, lookDirection.z) * Mathf.Rad2Deg;
        float smoothAngle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);

        if(lookDirection.magnitude >= 0.1f)
        {
            rigidBody.freezeRotation = false;
            transform.rotation = Quaternion.Euler(0f, smoothAngle, 0f);
        }
    }*/
}
