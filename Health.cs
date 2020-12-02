using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Text health;
    GameManager gameManager;

    
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

   
    void Update()
    {
        health.text = "Lifes: " + gameManager.lifes;
    }
}
