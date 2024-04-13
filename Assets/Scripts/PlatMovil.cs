using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatMovil : MonoBehaviour
{
    public float speed;
    private bool movingRight = true;
    public float LimitPlatPos;
    public float LimitPlatNeg;
    void Update()
    {
        Vector3 posicion = transform.position;


        if (posicion.x > LimitPlatPos || posicion.x < LimitPlatNeg)
        {
            movingRight = !movingRight;
        }


        if (movingRight)
        {
            posicion.x += speed * Time.deltaTime;
        }
        else
        {
            posicion.x -= speed * Time.deltaTime;

        }

        transform.position = posicion;
    }
}
