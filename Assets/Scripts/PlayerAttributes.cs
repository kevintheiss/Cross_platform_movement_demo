using UnityEngine;

/*
 * This class stores the player's global attribute variables
 */
public class PlayerAttributes : MonoBehaviour
{
    // movement speed
    [Tooltip("In ms^-1")] public float moveSpeed = 5f;

    // upward force applied to player jumps
    [Tooltip("In ms^-1")] public float jumpForce = 2f;

    // maximum player jump height
    [Tooltip("In ms^-1")] public float jumpHeight = 4f;
}
