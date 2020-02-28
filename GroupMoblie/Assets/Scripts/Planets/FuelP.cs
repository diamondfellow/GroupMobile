using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelP : MonoBehaviour
{
    static public bool OnFuel;
    // Start is called before the first frame update
    void Start()
    {
        OnFuel = false;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player" && SpaceMove.fuel < (PlayerPrefs.GetInt("MaxFuel") - 1))
        {
            SpaceMove.fuel += 2;
        }
    }
}
