﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodP : MonoBehaviour
{
    static public bool OnFood;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player" && SpaceHealth.food <= 49)
        {
            SpaceHealth.food += 1;
            OnFood = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            OnFood = false;
        }
    }
}
