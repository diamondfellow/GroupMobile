using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomish : MonoBehaviour
{
    public GameObject green;
    public GameObject purplpe;
    public GameObject red;
    public Transform blue;
    float x;
    float y;

    public float maxSpawnDistA = 5;
    float NmaxSpawnDistA;
    public float maxPlanetsA = 4;
    int counterA= 0;

    // Start is called before the first frame update
    void Start()
    {
        NmaxSpawnDistA = 0 - (maxSpawnDistA * 2);
        while(counterA <= maxPlanetsA)
        {
        int Rplanet = Random.Range(1, 3);
        switch (Rplanet)
        {
               case 1:
                    //  Debug.Log("Hello");
                    x = Random.Range(NmaxSpawnDistA, maxSpawnDistA);                   
                    y = Random.Range(NmaxSpawnDistA, maxSpawnDistA);
                    Instantiate(green, new Vector3(x, y, blue.position.z), Quaternion.identity);
                    counterA += 1;
                    break;
                case 2:
                     x = Random.Range(NmaxSpawnDistA, maxSpawnDistA);
                     y = Random.Range(NmaxSpawnDistA, maxSpawnDistA);
                    Instantiate(purplpe, new Vector3(x, y, blue.position.z), Quaternion.identity);
                    counterA += 1;
                    break;
                case 3:
                    x = Random.Range(NmaxSpawnDistA, maxSpawnDistA);
                    y = Random.Range(NmaxSpawnDistA, maxSpawnDistA);
                    Instantiate(red, new Vector3(x, y, blue.position.z), Quaternion.identity);
                    counterA += 1;
                    break;

            }
        } 

            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
