using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HSTimer : MonoBehaviour
{
    public static float HStimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HStimer += Time.deltaTime;

    }
}
