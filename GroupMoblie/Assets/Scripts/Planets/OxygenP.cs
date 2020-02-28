using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenP : MonoBehaviour
{
    static public bool OnOxygen;
    // Start is called before the first frame update
    void Start()
    {
        OnOxygen = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("Hello brain");
        if(collision.gameObject.tag == "Player" && SpaceHealth.oxygen < PlayerPrefs.GetInt("MaxOxygen"))
        SpaceHealth.oxygen += 1;
        OnOxygen = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            OnOxygen = false;
        }
    }
}
