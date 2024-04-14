using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    public GameObject PressE;
    public GameObject PressE2;
    public GameObject Stairs;
    public GameObject MessageCP;
    public bool alreadyReached = false;
    public GameObject MessageCP2;
    public bool alreadyReached2 = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        UI ui = FindObjectOfType<UI>();
        Player p = FindObjectOfType<Player>();
        if (collision.gameObject.CompareTag("Box"))
        {
            PressE.SetActive(true);
        }
        if (collision.gameObject.CompareTag("Box2"))
        {
            PressE2.SetActive(true);
        }
        if (collision.gameObject.CompareTag("Stairs"))
        {
            Stairs.SetActive(true);
        }
        if (collision.gameObject.CompareTag("Checkpoint"))
        {
            p.Respawn1 = false;
            p.Respawn2 = true;
            if (!alreadyReached)
            {
                MessageCP.SetActive(true);
                StartCoroutine(HideMessage(2f));
            }
            alreadyReached = true;

        }
        if (collision.gameObject.CompareTag("Checkpoint2"))
        {
            p.Respawn2 = false;
            p.Respawn3 = true;
            if (!alreadyReached2)
            {
                MessageCP2.SetActive(true);
                StartCoroutine(HideMessage(2f));
            }
            alreadyReached2 = true;
        }
        if (collision.gameObject.CompareTag("Water"))
        {
            ui.life--;
            p.isDead = true;
        }
        if (collision.gameObject.CompareTag("Pincho"))
        {
            ui.life--;
            p.isDead = true;
        }
        if (collision.gameObject.CompareTag("Banana"))
        {
            p.hasBanana = true;
            Destroy(collision.gameObject);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            PressE.SetActive(false);
        }
        if (collision.gameObject.CompareTag("Box2"))
        {
            PressE2.SetActive(false);
        }
        if (collision.gameObject.CompareTag("Stairs"))
        {
            Stairs.SetActive(false);
        }
    }

    public IEnumerator HideMessage(float seconds)
    {
        yield return new WaitForSeconds(seconds);

        MessageCP.SetActive(false);
        MessageCP2.SetActive(false);
    }
}
