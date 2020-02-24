using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ParticleSystem foo = GetComponent<ParticleSystem>();
        var shape = foo.shape;
        shape.rotation = new Vector3(0f, 0f, (transform.position.z - 115));
        if ((Input.touchCount > 0 || Input.GetMouseButton(0)) && SpaceMove.UIfuel >= 1)
        {           
            var main = foo.main;           
            main.maxParticles = 60;
            //main.gravityModifier = 0.5f;                        
           
            //GetComponent<ParticleSystem>().main = foo;
            //GetComponent<ParticleSystem>().gravityModifier = .5f;
        }
        else if(Input.touchCount <= 0 || Input.GetMouseButtonUp(0))
        {
            
            //GetComponent<ParticleSystem>().gravityModifier = 0f;
        }
    }
}
