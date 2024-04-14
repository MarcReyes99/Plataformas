using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    public int life;
    public TMP_Text lifes;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lifes.text = life.ToString();


    }
}
