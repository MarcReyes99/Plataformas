using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    [Header("Movimiento")]
    public float speed;
    public float horizontalMove;

    [Header("Deteccion de suelo")]
    [Min(0f)]
    public float raycastDistance;
    public LayerMask layerMask;
    public bool grounded;
    public Vector2 [] points;

    public Rigidbody2D rb;
    public float jumpForce;
    public GameObject PlatMovil;
    public GameObject PlatMovilVertical;
    public bool hasKey = false;
    public bool isDead = false;
    public bool Respawn1 = true;
    public bool Respawn2 = false;
    public bool Respawn3 = false;
    public Animator animator;
    public SpriteRenderer spriteRenderer;

    void FixedUpdate()
    {
        horizontalMove = Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime;
        transform.position += new Vector3(horizontalMove, 0, 0);

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (horizontalMove < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (horizontalMove > 0)
        {
            spriteRenderer.flipX = false;
        }

        grounded = false;
        foreach (Vector2 p in points)
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position + (Vector3)p, -Vector2.up, raycastDistance, layerMask);
            Debug.DrawRay(transform.position + (Vector3)p, -Vector2.up * raycastDistance, Color.red);
            Debug.DrawRay(transform.position + (Vector3)p, -Vector2.up * hit.distance, Color.green);
            if (hit.collider != null)
            {
                grounded = true;

                if (hit.collider.gameObject.CompareTag("PlatMovil"))
                {
                    transform.SetParent(PlatMovil.transform, true);
                }
                if (hit.collider.gameObject.CompareTag("PlatMovilVertical"))
                {
                    transform.SetParent(PlatMovilVertical.transform, true);
                }
            }
        }

        if(grounded == false) 
        {
            transform.SetParent(null, true);
        }

        if (grounded && Input.GetKey(KeyCode.Space))
        {
           rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        if (isDead)
        {
            if (Respawn1)
            {
                transform.position = new Vector3(-7, -2.5f, 0);
                isDead = false;
            }
            else if (Respawn2)
            {
                transform.position = new Vector3(-1, 17.5f, 0);
                isDead = false;
            }
            else if (Respawn3)
            {
                transform.position = new Vector3(3, 66.5f, 0);
                isDead = false;
            }
        }
    }
}
