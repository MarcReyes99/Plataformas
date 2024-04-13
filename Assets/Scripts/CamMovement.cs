using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    public float speed;
    public Transform target;
    public Vector3 offset;
    void LateUpdate()
    {
        Vector3 desiredPositionX = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Vector3 desiredPositionY = new Vector3(target.position.x + offset.x, target.position.y + offset.y, target.position.z + offset.z);
        Vector3 desiredPosition = new Vector3(desiredPositionX.x, desiredPositionY.y, desiredPositionY.z);

        transform.position = Vector3.Lerp(transform.position, desiredPosition, speed * Time.deltaTime);
    }
}
