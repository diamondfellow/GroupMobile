using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadCustom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void Load()
    {
        GameObject music = GameObject.FindGameObjectWithTag("music");
        DontDestroyOnLoad(music);
        music.tag = "music2";
        SceneManager.LoadScene(9);
    }
    public void LoadMenu()
    {

        CustomPlay.isDefault = false;
        SceneManager.LoadScene(0);

    }
}
