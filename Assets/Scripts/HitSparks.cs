using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitSparks : MonoBehaviour
{
    
    [SerializeField] private ParticleSystem sparks;

    private void OnCollisionEnter(Collision other){
        sparks.Play();
    }
}
