using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalP : MonoBehaviour
{
    static public bool OnMetal;
    // Start is called before the first frame update
    void Start()
    {
        OnMetal = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && SpaceHealth.metal < PlayerPrefs.GetInt("MaxMetal"))
        {
            SpaceHealth.metal += 1;
        }
    }
}
