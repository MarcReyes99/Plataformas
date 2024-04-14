using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
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
                StartCoroutine(HideMessage(2f));
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
                    StartCoroutine(HideMessage(2f));
                }
            }
        }
    }

    public IEnumerator HideMessage(float seconds)
    {
        yield return new WaitForSeconds(seconds);

        Key.SetActive(false);
        DoesntHaveKey.SetActive(false);
    }
}
