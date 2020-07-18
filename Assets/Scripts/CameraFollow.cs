using UnityEngine;

/*
 * This class moves the main camera to follow the player
 */

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform target; // target object for camera to follow
    //[SerializeField] float moveSpeed = 10f; // speed of camera movement
    [SerializeField] Vector3 offset; // camera position in relation to target

    //[SerializeField] bool useOffsetValues;

    //[SerializeField] float rotateSpeed = 0f;

    //[SerializeField] GameObject player;

    //private PlayerInput playerInput;

   // [SerializeField] Transform pivot;

    /*void Awake()
    {
        playerInput = player.GetComponent<PlayerInput>();
        //SetOffset();
    }*/

    void LateUpdate()
    {
        CameraMove();
    }

    /*void SetOffset()
    {
        if (!useOffsetValues)
        {
            offset = target.position - transform.position;
        }

        pivot.transform.position = target.transform.position;
        pivot.transform.parent = target.transform;

        Cursor.lockState = CursorLockMode.Locked;
    }*/

    /*
     * Move the camera behind the player
     */
    void CameraMove()
    {
        transform.position = target.position - offset;
        transform.LookAt(target);
    }

    /*void CameraMove()
    {
        float horizontal = playerInput.rotateHorz * rotateSpeed;
        target.Rotate(0f, horizontal, 0f);

        float vertical = playerInput.rotateVert * rotateSpeed;
        pivot.Rotate(vertical, 0f, 0f);

        float targetXAngle = pivot.eulerAngles.x;
        float targetYAngle = target.eulerAngles.y;
        Quaternion rotation = Quaternion.Euler(targetXAngle, targetYAngle, 0f);
        transform.position = target.position - (rotation * offset);

        if(transform.position.y < target.position.y)
        {
            transform.position = new Vector3(transform.position.x, target.position.y - 0.5f, transform.position.z);
        }

        transform.LookAt(target);
    }*/
}
