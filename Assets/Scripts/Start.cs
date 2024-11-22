using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start : MonoBehaviour
{
    public GameObject ball;
    public GameObject Player;
    public GameObject Computer;
    public GameObject line;
    public GameObject Score;

    public GameObject StartUI;
    public void StartGame()
    {
        ball.SetActive(true);
        Player.SetActive(true);
        Computer.SetActive(true);
        line.SetActive(true);
        Score.SetActive(true);
        StartUI.SetActive(false);
    }

    public void exitGame()
    {
        Application.Quit();
    }
    
}
