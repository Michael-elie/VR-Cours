using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

public class ScoreUi : MonoBehaviour
{
    private Tuple<GameObject, int> gbtg;
  
    [SerializeField] private TextMeshProUGUI _scoreText;
    
    private void Update()
    {
        _scoreText.text =  ScoreManager._score + " / "+ ScoreManager._scoreTarget;
    }

    

}
