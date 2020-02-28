using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MMMusic : MonoBehaviour
{
    public AudioSource Music;
    // Start is called before the first frame update
    void Start()
    {
        GameObject music = GameObject.FindGameObjectWithTag("music2");
        if(music == null)
        {
            Music.Play();
        }
        else
        {
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
