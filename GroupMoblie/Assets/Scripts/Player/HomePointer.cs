using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomePointer : MonoBehaviour
{
    public Transform HomePlanet;
    public Transform Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.up = (HomePlanet.position - Player.position) * 1;
    }
}
