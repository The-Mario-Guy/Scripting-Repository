using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizOneCodingChallenge : MonoBehaviour
{
    public int score = 0;
    public string playerName = "Steve";
    public float health = 100f;
    // Start is called before the first frame update
    void Start()
    {
        IncreaseScore();
        PrintPlayerName();
        DecreaseHealthVariable();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void IncreaseScore()
    {
        score = score +1;
    }
    void PrintPlayerName()
    {
        Debug.Log(playerName);
    }
    void DecreaseHealthVariable()
    {
        health = health - 20;
    }
}
