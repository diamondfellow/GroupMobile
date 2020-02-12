using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetCheck : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("foo");
        if (collision.gameObject.tag == "green" || collision.gameObject.tag == "purple" || collision.gameObject.tag == "red")
        {
            Debug.Log("do the thoign");
            Destroy(gameObject);
            Randomish.counterA -= 1;
        }
    }
}
