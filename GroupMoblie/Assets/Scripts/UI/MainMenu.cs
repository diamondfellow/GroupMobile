using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public static bool paused;
    public Canvas Interface;
    public Canvas Pause;
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
        Pause.enabled = false;
        Time.timeScale = 1;
        paused = false;
    }
    public void Pausegame()
    {
        Pause.enabled = true;
        Time.timeScale = 0;        
        paused = true; 

    }
    public void StartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
        GameObject music = GameObject.FindGameObjectWithTag("music");
        Destroy(music);
        GameObject music2 = GameObject.FindGameObjectWithTag("music2");
        Destroy(music2);
    }
    public void MainMenuo()
    {
        SceneManager.LoadScene(0);

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
            music.tag = "music2";
            SceneManager.LoadScene(4);
        }
    }
    public void Hints2()
    {
        SceneManager.LoadScene(6);
    }
    public void Controls()
    {
        GameObject music = GameObject.FindGameObjectWithTag("music");
        GameObject music2 = GameObject.FindGameObjectWithTag("music2");
        Destroy(music);
        Destroy(music2);
        SceneManager.LoadScene(5);
    }
}
