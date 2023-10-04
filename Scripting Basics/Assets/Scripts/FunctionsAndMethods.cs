using OpenCover.Framework.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsAndMethods : MonoBehaviour
{
    /*Functions are blocks of Code that perform specific tasks and are not associated with any specific obkect or class. They can be called and executed independently.
     * Methods, on the other hand, are functions that are associated with a specific object or class. They can be called and executed on instances of that object or class.*/

    //declare our Variables
    private AudioSource _audioSource;
    private float _speed = 10f;
    public float _playerHealthAmount = 12f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // Function to play sound effect
    private void PlaySoundEffect(AudioClip soundEffect)
    {
        _audioSource.PlayOneShot(soundEffect);
    }

    //Function to detect Trigger
    private void OnTriggerEnter(Collider other)
    {
        
    }
    // Creating some simple functions

    // Method to move the enemy
    private void MoveEnemy()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);    
    }
    //Method to return a value
    public int PlayerHealth(int amount)
    {
        _playerHealthAmount -= amount;

        return _playerHealthAmount;
    }
}
