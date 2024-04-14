using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBox : MonoBehaviour
{
    public GameObject PressE;
    void Update()
    {
        Player p = FindObjectOfType<Player>();
        if (Input.GetKey(KeyCode.E) && PressE.activeSelf)
        {
            if (gameObject.CompareTag("Box"))
            {
                p.hasKey = true;
            }
            else if (gameObject.CompareTag("Box2"))
            {
                if (p.hasKey)
                {

                }
                else if (!p.hasKey)
                {
                     
                }
            }
        }
    }
}
