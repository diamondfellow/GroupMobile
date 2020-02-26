using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandingSoud : MonoBehaviour
{
    public AudioSource Sound;
    public AudioClip lanidng;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Sound.PlayOneShot(lanidng);
    }
}
