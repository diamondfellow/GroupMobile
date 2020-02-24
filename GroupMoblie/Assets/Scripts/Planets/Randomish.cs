using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomish : MonoBehaviour
{
    public GameObject food;
    public GameObject oxygen;
    public GameObject fuel;
    public GameObject metal; 
    public Transform blue;

    float x;
    float y;
    GameObject newobject;
    public float maxScale;
    public float minScale;
    float scale;

    
    float maxPlanetsA = 0;
    float maxPlanetsB = 0;
    float maxPlanetsC = 0;
    float maxPlanetsD = 0;
    public int maxPlanetforQuad = 1;
    public static int counter= 0;
    int check;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        maxPlanetsA = 0;
        maxPlanetsB = 0;
        maxPlanetsC = 0;
        maxPlanetsD = 0;
        check = (maxPlanetforQuad * 4);
        while (counter < check)
        {
            if(maxPlanetsA < maxPlanetforQuad)
            {
                SpawnPlanet(0f, 400f, 0f, 400f);
                maxPlanetsA += 1;
                counter += 1;
            }
            else if (maxPlanetsB < maxPlanetforQuad)
            {
                SpawnPlanet(-400f, 0f, 0f, 400f);
                maxPlanetsB += 1;
                counter += 1;
            }
            else if (maxPlanetsC < maxPlanetforQuad)
            {
                SpawnPlanet(-400f, 0f, -400f, 0f);
                maxPlanetsC += 1;
                counter += 1;
            }
            else if (maxPlanetsD < maxPlanetforQuad)
            {
                SpawnPlanet(0f, 400f, -400f, 0f);
                maxPlanetsD += 1;
                counter += 1;
            }
        }           
    }
    public void SpawnPlanet(float NmaxSpawnDistX, float maxSpawnDistX, float NmaxSpawnDistY, float maxSpawnDistY)
    {
            int Rplanet = Random.Range(1, 5);
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
                    newobject = Instantiate(fuel, new Vector3(x, y, blue.position.z), Quaternion.identity);
                    newobject.transform.localScale = new Vector3(scale, scale, 1);
                    //counterA += 1;
                    break;
                case 2:
                    x = Random.Range(NmaxSpawnDistX, maxSpawnDistX);
                    y = Random.Range(NmaxSpawnDistY, maxSpawnDistY);
                    scale = Random.Range(minScale, maxScale);
                    newobject = Instantiate(oxygen, new Vector3(x, y, blue.position.z), Quaternion.identity);
                    newobject.transform.localScale = new Vector3(scale, scale, 1);
                    //counterA += 1;
                    break;
                case 3:
                    x = Random.Range(NmaxSpawnDistX, maxSpawnDistX);
                    y = Random.Range(NmaxSpawnDistY, maxSpawnDistY);
                    scale = Random.Range(minScale, maxScale);
                    newobject = Instantiate(metal, new Vector3(x, y, blue.position.z), Quaternion.identity);
                    newobject.transform.localScale = new Vector3(scale, scale, 1);
                    //counterA += 1;
                    break;
                case 4:
                    x = Random.Range(NmaxSpawnDistX, maxSpawnDistX);
                    y = Random.Range(NmaxSpawnDistY, maxSpawnDistY);
                    scale = Random.Range(minScale, maxScale);
                    newobject = Instantiate(food, new Vector3(x, y, blue.position.z), Quaternion.identity);
                    newobject.transform.localScale = new Vector3(scale, scale, 1);
                    //counterA += 1;
                    break;

            }      
    }
}
