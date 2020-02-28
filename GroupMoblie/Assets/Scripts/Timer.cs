using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float startingTimer = 10.0f;
    public Text TimeToString;
    public static bool gameStart = false;
    bool keepTiming;
    float timer;

  

   
    void Start()
    {
        startingTimer -= Time.deltaTime;
    }

    

    void Update()
    {
        if (gameStart = true)
        {
            
        }

        if (keepTiming)
        {
            UpdateTime();
        }
    }

    void UpdateTime()
    {
        timer = Time.time - startingTimer;
        
    }

    float StopTimer()
    {
        keepTiming = false;
        return timer;
    }
}
