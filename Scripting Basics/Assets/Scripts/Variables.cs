using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    //Declaring Variables

    //Public Variables/Global Variables
    public Variables cheese;
    public float speed = 20;
    public int score;
    public string playerName = "Stanley";
    public bool _isPlayerActive = true;

    //Private Member/Goal Variables
    private float _maxSpeed = 100;
    private int _totalScore = 0;
    private string _username = "Parable";
    private bool _isGameOver = false;  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //declaring local variables
        float horizontalInput = Input.GetAxis("Horizontal");
    }
    private void UpdateScore(int amount)
    {
       //using a local variable to update the total score
       _totalScore += amount;
    }
}
