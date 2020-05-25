using UnityEngine;

/*
 * This class stores the camera's global attribute variables
 */
public class CameraAttributes : MonoBehaviour
{
    [Tooltip("In ms^-1")] public float cameraMoveSpeed = 200f; // camera movement speed
    [Tooltip("In ms^-1")] public float cameraLookSpeed = 150f; // camera look speed
}
