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
    GameObject newobject;
    public int maxScale;
    public int minScale;
    float scale;

    public float maxSpawnDistA = 5;
    float NmaxSpawnDistA;
    public float maxPlanetsA = 4;
    public static int counterA= 0;

    // Start is called before the first frame update
    void Start()
    {
        NmaxSpawnDistA = 0 - (maxSpawnDistA * 2);
        while(counterA <= maxPlanetsA)
        {
        int Rplanet = Random.Range(1, 4);
            float x = 0;
            float y = 0;
            float scale = 0;
            newobject = null;

        switch (Rplanet)
        {
               case 1:
                    //  Debug.Log("Hello");
                    x = Random.Range(NmaxSpawnDistA, maxSpawnDistA);                   
                    y = Random.Range(NmaxSpawnDistA, maxSpawnDistA);
                    scale = Random.Range(minScale, maxScale);
                     newobject = Instantiate(green, new Vector3(x, y, blue.position.z), Quaternion.identity);
                    newobject.transform.localScale = new Vector3(scale, scale, 1);
                    counterA += 1;
                    break;
                case 2:
                     x = Random.Range(NmaxSpawnDistA, maxSpawnDistA);
                     y = Random.Range(NmaxSpawnDistA, maxSpawnDistA);
                    scale = Random.Range(minScale, maxScale);
                    newobject = Instantiate(purplpe, new Vector3(x, y, blue.position.z), Quaternion.identity);
                    newobject.transform.localScale = new Vector3(scale, scale, 1);
                    counterA += 1;
                    break;
                case 3:
                    x = Random.Range(NmaxSpawnDistA, maxSpawnDistA);
                    y = Random.Range(NmaxSpawnDistA, maxSpawnDistA);
                    scale = Random.Range(minScale, maxScale);
                    newobject = Instantiate(red, new Vector3(x, y, blue.position.z), Quaternion.identity);
                    newobject.transform.localScale = new Vector3(scale, scale, 1);
                    counterA += 1;
                    break;

            }
        } 

            
    }
}
