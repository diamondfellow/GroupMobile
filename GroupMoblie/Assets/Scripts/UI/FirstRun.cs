using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstRun : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("FirstRun") == 0)
        {
            PlayerPrefs.SetInt("FirstRun", 1);
            PlayerPrefs.SetInt("MaxPlanets", 20);
            PlayerPrefs.SetFloat("MaxFuel", 750);
            PlayerPrefs.SetInt("MaxOxygen", 200);
            PlayerPrefs.SetInt("MaxFood", 30);
            PlayerPrefs.SetInt("MaxMetal", 300);
            PlayerPrefs.SetFloat("GravityStrength", 1.5f);
            PlayerPrefs.SetFloat("ThrustPower", 3);
            PlayerPrefs.SetFloat("RotationSpeed", 3);
            PlayerPrefs.SetInt("MetalRequirement", 1000);
            PlayerPrefs.SetInt("MaxHealth", 100);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
