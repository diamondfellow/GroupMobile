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
        if (collision.gameObject.tag == "fuel" || collision.gameObject.tag == "oxygen" 
            || collision.gameObject.tag == "metal" || collision.gameObject.tag == "food")
        {
            Debug.Log("do the thoign");
            Destroy(gameObject);
            int random = Random.Range(1, 5);
            switch (random)
            {
                case 1:
                    GetComponent<Randomish>().SpawnPlanet(0f, 100f, 0f, 100f);
                    break;
                case 2:
                    GetComponent<Randomish>().SpawnPlanet(-100f, 0f, 0f, 100f);
                    break;
                case 3:
                    GetComponent<Randomish>().SpawnPlanet(-100f, 0f, -100f, 0f);
                    break;
                case 4:
                    GetComponent<Randomish>().SpawnPlanet(0f, 100f, -100f, 0f);
                    break;
            }
            

        }
    }
}
