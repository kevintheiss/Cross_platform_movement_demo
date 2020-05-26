using UnityEngine;

/*
 * This class stores the player's global attribute variables
 */
public class PlayerAttributes : MonoBehaviour
{
    // movement speed
    [Tooltip("In ms^-1")] public float moveSpeed = 200f;
    [Tooltip("In ms^-1")] public float lookSpeed = 150f;
}
