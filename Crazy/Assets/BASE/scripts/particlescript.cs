using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particlescript : MonoBehaviour
{
    [SerializeField] ParticleSystem Particles_Dust = null;

    void OnTriggerEnter2D (Collider2D collision)   
        {
            DustParticle();
            Debug.Log("trigger");
        }
    

    public void DustParticle()
    {
        Particles_Dust.Play();
    }
}
