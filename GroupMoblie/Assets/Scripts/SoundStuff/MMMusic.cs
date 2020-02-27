using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MMMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        GameObject music = GameObject.FindGameObjectWithTag("music");
        DontDestroyOnLoad(music); 
        if(SceneManager.GetActiveScene().name == "MainMenu" ||
           SceneManager.GetActiveScene().name == "Hints" ||
           SceneManager.GetActiveScene().name == "Hints2")
        {
            return;
        }
        else
        {
            Destroy(music);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
