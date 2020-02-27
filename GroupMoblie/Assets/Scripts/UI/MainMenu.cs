using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public static bool paused;
    // Start is called before the first frame update
    void Start()
    {
        paused = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void Quit()
    {
        Application.Quit();
    }
    public void Resume()
    {
        GetComponent<Canvas>().enabled = false;
        Time.timeScale = 1;
        paused = false;
    }
    public void Pause()
    {
        Time.timeScale = 0;
        GetComponent<Canvas>().enabled = true;
        paused = true; 

    }
    public void StartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
        GameObject music = GameObject.FindGameObjectWithTag("music");
        Destroy(music);
    }
    public void MainMenuo()
    {
        GameObject music = GameObject.FindGameObjectWithTag("music");
        if(music == null)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            DontDestroyOnLoad(music);
            SceneManager.LoadScene(0);
        }
              
    }
    public void Hints()
    {
        GameObject music = GameObject.FindGameObjectWithTag("music");
        if (music == null)
        {
            SceneManager.LoadScene(4);
        }
        else
        {
            DontDestroyOnLoad(music);
            SceneManager.LoadScene(4);
        }
    }
    public void Hints2()
    {
        GameObject music = GameObject.FindGameObjectWithTag("music");
        if (music == null)
        {
            SceneManager.LoadScene(6);
        }
        else
        {
            DontDestroyOnLoad(music);
            SceneManager.LoadScene(6);
        }
    }
    public void Controls()
    {
        SceneManager.LoadScene(5);
    }
}
