using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWrap : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("bruh");
            Vector3 transfer = collision.gameObject.GetComponent<Transform>().position;
            transfer.x *= -1;
            transfer.y *= -1;
            collision.gameObject.GetComponent<Transform>().position = transfer;
        }
    }
}
