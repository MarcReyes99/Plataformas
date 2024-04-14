using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Climb : MonoBehaviour
{
    public float speed;
    public bool isKeyPressed = false;
    public GameObject Stairs;
    public GameObject Player;
    public Rigidbody2D rb;

    void Update()
    {
        if (Input.GetKey(KeyCode.W) && Stairs.activeSelf)
        {
            isKeyPressed = true;
            rb.gravityScale = 0;
        }
        else if(!Stairs.activeSelf)
        {
            isKeyPressed = false;
            rb.gravityScale = 3;
        }

        if (isKeyPressed)
        {
            Player.transform.position += new Vector3(0, Input.GetAxis("Climb") * speed * Time.deltaTime, 0);
        }
    }
}
