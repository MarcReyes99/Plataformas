using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float raycastDistance;
    public LayerMask LayerMask;
    public bool grounded;

    public List<Vector2> points;
    void FixedUpdate()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime, 0, 0);

        foreach (Vector2 p in points)
        {

        }

        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up, raycastDistance, LayerMask);
        Debug.DrawRay(transform.position, -Vector2.up * raycastDistance, Color.red);
        Debug.DrawRay(transform.position, -Vector2.up * hit.distance, Color.green);

        if (hit.collider != null)
        {
            grounded = true;
        }
        else
        {
            grounded = false;
        }
    }


}
