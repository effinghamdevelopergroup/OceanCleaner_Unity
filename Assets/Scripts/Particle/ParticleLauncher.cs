using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleLauncher : MonoBehaviour
{
    public ParticleSystem Particle;

    // Start is called before the first frame update
    void Start()
    {
        Particle.transform.position = this.transform.position;
        Particle.Stop();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
