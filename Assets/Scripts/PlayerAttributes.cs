using UnityEngine;

/*
 * This class stores the player's global attribute variables
 */
public class PlayerAttributes : MonoBehaviour
{
    [Tooltip("In ms^-1")] public float playerMoveSpeed = 200f; // player movement speed
    [Tooltip("In ms^-1")] public float playerLookSpeed = 150f; // player look speed
}
