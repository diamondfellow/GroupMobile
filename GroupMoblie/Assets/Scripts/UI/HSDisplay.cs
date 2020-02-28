using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HSDisplay : MonoBehaviour
{
    public Text highScore;
    int minute = 0;
    int hours = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.SetInt("HSTime", 0);
    }

    // Update is called once per frame
    void Update()
    {
        int transfer = PlayerPrefs.GetInt("HSTime");
        float check = transfer / 60;
        if(check >= 1)
        {
            Debug.Log("minute");
            minute = Mathf.FloorToInt(check);
            transfer = transfer - Mathf.FloorToInt(check) * 60;
            float chk = minute / 60;
            if(chk >= 1)
            {
                Debug.Log(hours);
                hours = (Mathf.FloorToInt(chk));
                minute = minute - (Mathf.FloorToInt(chk) * 60);
            }
        }
        highScore.text = (hours + ":" + minute + ":" + transfer);

        if (PlayerPrefs.GetInt("CurrentTime") > PlayerPrefs.GetInt("HSTime") && CustomPlay.isDefault)
        {
            PlayerPrefs.SetInt("HSTime", PlayerPrefs.GetInt("CurrentTime"));
            
        }
    }
}
