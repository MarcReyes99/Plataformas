using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    public int life = 3;
    public GameObject Lifes3;
    public GameObject Lifes2;
    public GameObject Lifes1;
    public GameObject Lifes0;
    public GameObject Victory;
    public GameObject Defeat;

    void Start()
    {
        life = 3;
    }
    void Update()
    {
        Player p = FindObjectOfType<Player>();
        GameManager gm = FindObjectOfType<GameManager>();

        if (life == 3)
        {
            Lifes3.SetActive(true);
            Lifes0.SetActive(false);
        }
        if (life == 2)
        {
            Lifes2.SetActive(true);
            Lifes3.SetActive(false);
        }
        if (life == 1)
        {
            Lifes1.SetActive(true);
            Lifes2.SetActive(false);
        }
        if (life <= 0)
        {
            Lifes1.SetActive(false);
            Lifes0.SetActive(true);
            Defeat.SetActive(true);
            Time.timeScale = 0f;
        }
        if (p.hasBanana)
        {
            Victory.SetActive(true);
            Time.timeScale = 0f;
            life = 3;
        }
    }
}
