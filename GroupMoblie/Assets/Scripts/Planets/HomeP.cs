﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeP : MonoBehaviour
{
    public static int homeMetal;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(homeMetal > 999)
        {
            SceneManager.LoadScene("Win");
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && SpaceHealth.metal >= 1)
        {
            SpaceHealth.metal -= 1;
            homeMetal += 1;
        }

    }
}
