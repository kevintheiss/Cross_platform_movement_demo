using UnityEngine;

/*
 * This class moves the main camera to follow the player
 */
public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform target; // target object for camera to follow
    [SerializeField] Vector3 offset; // camera position in relation to target

    /* 
     * LateUpdate is called once per frame after all other update functions
     */
    void LateUpdate()
    {
        CameraMove();
    }

    /*
     * Move the camera to follow the player
     */
    void CameraMove()
    {
        transform.position = target.position - offset; // set the camera offset in relation to the player
        transform.LookAt(target); // keep the camera facing the player
    }
}
