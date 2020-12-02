using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    public int coins = 0;
    public int lifes = 3;

    public void AddCoins()
    {
        coins += 1;
     
    }

    public void Dead()
    {
        lifes -= 1;
        if (lifes <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        else
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
