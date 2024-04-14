using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventInteract : MonoBehaviour
{
    public GameObject PressE;
    public GameObject PressE2;
    public GameObject Stairs;

    private void OnTriggerEnter2D(Collider2D collision)
    {
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
}
