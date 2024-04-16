using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _ballPrefab;
    [SerializeField] private GameObject _launchPoint;
    [SerializeField] private List<GameObject> _targetsPoints;
    [SerializeField] private List<GameObject> _targets;
    [SerializeField] private GameObject _conservePrefab;
    [SerializeField] private List<GameObject> _balls;
    private void Update()
    {
       
    }

    public void RespawnTarget()
    {
                if (_targets != null) {
                    for (int i = 0; i < _targets.Count; i++) {
                        Destroy(_targets[i]);
                    }
                    _targets.Clear();
                    ScoreManager._score = 0;
                }
                foreach (GameObject target in _targetsPoints) {
                    GameObject newconserve = Instantiate(_conservePrefab, target.transform.position, quaternion.identity);
                    if (_targets != null) _targets.Add(newconserve);
                }
    }

    
    
    public void SpawnBall() {
        GameObject newball = Instantiate(_ballPrefab, _launchPoint.transform.position, _launchPoint.transform.rotation, null);
        _balls.Add(newball);
    }
}
