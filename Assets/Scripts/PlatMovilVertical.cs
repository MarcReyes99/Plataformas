using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatMovilVertical : MonoBehaviour
{
    public float speed;
    private bool goingUp = true;
    public float LimitPlatPos;
    public float LimitPlatNeg;
    void Update()
    {
        Vector3 posicion = transform.position;


        if (posicion.y > LimitPlatPos || posicion.y < LimitPlatNeg)
        {
            goingUp = !goingUp;
        }


        if (goingUp)
        {
            posicion.y += speed * Time.deltaTime;
        }
        else
        {
            posicion.y -= speed * Time.deltaTime;
        }

        transform.position = posicion;
    }
}
