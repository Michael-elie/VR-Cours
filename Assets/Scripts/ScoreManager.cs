using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static int _score ;
    public static int _scoreTarget = 10;
    public static Action TargetFallen;
    
    private void Awake()
    {
        _score = 0;
        TargetFallen += UpdateScore;
        
    }
    private void UpdateScore()
    {
        _score++;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Conserve"))
        {
            TargetFallen.Invoke();
            Destroy(other.collider.GameObject());
            Debug.Log(_score);
        }
        else if (other.collider.CompareTag("Ball"))
        {
            Destroy(other.collider.GameObject());
            
        }
    }
    
   
}
