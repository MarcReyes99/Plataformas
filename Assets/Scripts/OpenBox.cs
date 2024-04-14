using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBox : MonoBehaviour
{
    public GameObject PressE;
    public GameObject InvisiblePlatform;
    public GameObject Key;
    public GameObject DoesntHaveKey;
    void Update()
    {
        Player p = FindObjectOfType<Player>();
        if (Input.GetKey(KeyCode.E) && PressE.activeSelf)
        {
            if (gameObject.CompareTag("Box"))
            {
                p.hasKey = true;
                Key.SetActive(true);
            }
        }
        if (Input.GetKey(KeyCode.E) && PressE.activeSelf)
        {
            if (gameObject.CompareTag("Box2"))
            {
                if (p.hasKey)
                {
                    InvisiblePlatform.SetActive(true);
                }
                else if (!p.hasKey)
                {
                    DoesntHaveKey.SetActive(true);
                }
            }
        }
    }
}
