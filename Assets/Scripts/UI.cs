using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    public int life = 3;
    //public TMP_Text lifes;
    //public GameObject Victory;
    //public GameObject Defeat;
    void Update()
    {
        Player p = FindObjectOfType<Player>();
        //lifes.text = life.ToString();

        if (life <= 0)
        {
            //Defeat.SetActive(true);
            life = 3;
        }
    }
}
