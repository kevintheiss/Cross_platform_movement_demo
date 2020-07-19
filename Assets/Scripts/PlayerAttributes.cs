using UnityEngine;

/*
 * This class stores the player's global attribute variables
 */
public class PlayerAttributes : MonoBehaviour
{
    // movement speed
    [Tooltip("In ms^-1")] public float moveSpeed = 5f;
    //[Tooltip("In ms^-1")] public float lookSpeed = 6f;
    [Tooltip("In ms^-1")] public float jumpForce = 2f;
    [Tooltip("In ms^-1")] public float jumpHeight = 4f;
    [HideInInspector] public bool isGrounded;
}
