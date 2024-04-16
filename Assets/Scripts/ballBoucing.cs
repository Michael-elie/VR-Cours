using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballBoucing : MonoBehaviour
{

    [SerializeField] private AudioSource BoucingGroundSound;
    [SerializeField] private AudioSource ImpactEffectSound;
    
  

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Conserve"))
        {
            ImpactEffectSound.Play();
            other.collider.attachedRigidbody.AddExplosionForce(0.2f,other.collider.transform.position,0.2f);
        }
        else
        {
            BoucingGroundSound.Play();
            
        }
    }
}
