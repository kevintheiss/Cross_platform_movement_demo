using UnityEngine;

/*
 * This class moves the main camera to follow the player
 */

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform target; // target object for camera to follow
    [SerializeField] float moveSpeed = 10f; // speed of camera movement
    [SerializeField] Vector3 offset; // camera position in relation to target

    void FixedUpdate()
    {
        CameraMove();
    }

    /*
     * Move the camera behind the player
     */
    void CameraMove()
    {
        Vector3 targetPosition = target.position + offset; // desired position of the camera in relation to the player
        Vector3 movementVector = Vector3.Lerp(transform.position, targetPosition, moveSpeed * Time.deltaTime); // interpolate the camera's movement vector
        transform.position = movementVector; // update the camera's position to follow the movement vector

        transform.LookAt(target); // make sure the camera is facing the target
    }
}
