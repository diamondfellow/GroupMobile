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

    
    float maxPlanetsA = 0;
    float maxPlanetsB = 0;
    float maxPlanetsC = 0;
    float maxPlanetsD = 0;
    public int maxPlanetforQuad = 40;
    public static int counter= 0;
    int check;

    // Start is called before the first frame update
    void Start()
    {
        check = (maxPlanetforQuad * 4);
        while (counter < check)
        {
            if(maxPlanetsA < maxPlanetforQuad)
            {
                SpawnPlanet(0f, 100f, 0f, 100f);
                maxPlanetsA += 1;
                counter += 1;
            }
            else if (maxPlanetsB < maxPlanetforQuad)
            {
                SpawnPlanet(-100f, 0f, 0f, 100f);
                maxPlanetsB += 1;
                counter += 1;
            }
            else if (maxPlanetsC < maxPlanetforQuad)
            {
                SpawnPlanet(-100f, 0f, -100f, 0f);
                maxPlanetsC += 1;
                counter += 1;
            }
            else if (maxPlanetsD < maxPlanetforQuad)
            {
                SpawnPlanet(0f, 100f, -100f, 0f);
                maxPlanetsD += 1;
                counter += 1;
            }
        }           
    }
    public void SpawnPlanet(float NmaxSpawnDistX, float maxSpawnDistX, float NmaxSpawnDistY, float maxSpawnDistY)
    {
            int Rplanet = Random.Range(1, 4);
            float x = 0;
            float y = 0;
            float scale = 0;
            newobject = null;
            switch (Rplanet)
            {
                case 1:                   
                    x = Random.Range(NmaxSpawnDistX, maxSpawnDistX);
                    y = Random.Range(NmaxSpawnDistY, maxSpawnDistY);
                    scale = Random.Range(minScale, maxScale);
                    newobject = Instantiate(green, new Vector3(x, y, blue.position.z), Quaternion.identity);
                    newobject.transform.localScale = new Vector3(scale, scale, 1);
                    //counterA += 1;
                    break;
                case 2:
                    x = Random.Range(NmaxSpawnDistX, maxSpawnDistX);
                    y = Random.Range(NmaxSpawnDistY, maxSpawnDistY);
                    scale = Random.Range(minScale, maxScale);
                    newobject = Instantiate(purplpe, new Vector3(x, y, blue.position.z), Quaternion.identity);
                    newobject.transform.localScale = new Vector3(scale, scale, 1);
                    //counterA += 1;
                    break;
                case 3:
                    x = Random.Range(NmaxSpawnDistX, maxSpawnDistX);
                    y = Random.Range(NmaxSpawnDistY, maxSpawnDistY);
                    scale = Random.Range(minScale, maxScale);
                    newobject = Instantiate(red, new Vector3(x, y, blue.position.z), Quaternion.identity);
                    newobject.transform.localScale = new Vector3(scale, scale, 1);
                    //counterA += 1;
                    break;
            }      
    }
}
