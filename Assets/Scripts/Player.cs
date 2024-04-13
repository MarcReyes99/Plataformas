using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Movimiento")]
    public float speed;

    [Header("Deteccion de suelo")]
    [Min(0f)]
    public float raycastDistance;
    public LayerMask layerMask;
    public bool grounded;
    public Vector2 [] points;

    public Rigidbody2D rb;
    public float jumpForce;
    public GameObject PlatMovil;
    void FixedUpdate()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime, 0, 0);

        grounded = false;
        foreach (Vector2 p in points)
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position + (Vector3)p, -Vector2.up, raycastDistance, layerMask);
            Debug.DrawRay(transform.position + (Vector3)p, -Vector2.up * raycastDistance, Color.red);
            Debug.DrawRay(transform.position + (Vector3)p, -Vector2.up * hit.distance, Color.green);
            if (hit.collider != null)
            {
                grounded = true;

                if(hit.collider.gameObject.CompareTag("PlatMovil"))
                {
                    transform.SetParent(PlatMovil.transform, true);
                }
            }
        }

        if(grounded == false) 
        {
            transform.SetParent(null, true);
        }

        if (grounded && Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
