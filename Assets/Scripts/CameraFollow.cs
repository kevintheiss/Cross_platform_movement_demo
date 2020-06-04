using UnityEngine;

/*
 * This class moves the main camera to follow the player
 */

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform target; // target object for camera to follow
    //[SerializeField] float moveSpeed = 10f; // speed of camera movement
    [SerializeField] Vector3 offset; // camera position in relation to target

    [SerializeField] bool useOffsetValues;

    [SerializeField] float rotateSpeed = 0f;

    [SerializeField] GameObject player;

    private PlayerInput playerInput;

    void Awake()
    {
        playerInput = player.GetComponent<PlayerInput>();
        SetOffset();
    }

    void LateUpdate()
    {
        CameraMove();
    }

    void SetOffset()
    {
        if (!useOffsetValues)
        {
            offset = target.position - transform.position;
        }
    }

    /*
     * Move the camera behind the player
     */
    /*void CameraMove()
    {
        transform.position = target.position - offset;
        transform.LookAt(target);
    }*/

    void CameraMove()
    {
        float horizontal = playerInput.rotateHorz * rotateSpeed;
        target.Rotate(0f, horizontal, 0f);

        float vertical = playerInput.rotateVert * rotateSpeed;
        target.Rotate(vertical, 0f, 0f);

        float targetXAngle = target.eulerAngles.x;
        float targetYAngle = target.eulerAngles.y;
        Quaternion rotation = Quaternion.Euler(targetXAngle, targetYAngle, 0f);
        transform.position = target.position - (rotation * offset);

        transform.LookAt(target);
    }
}
