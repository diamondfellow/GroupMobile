using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWrap : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("??");
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("bruh");
            Vector3 transfer = collision.gameObject.GetComponent<Transform>().position;
            transfer.x *= -1;
            transfer.y *= -1;
            if(transfer.x > 0)
            {
                transfer.x -= 2;
            }
            if(transfer.y > 0)
            {
                transfer.y -= 2;
            }
            if(transfer.x < 0)
            {
                transfer.x += 2;
            }
            if(transfer.y < 0)
            {
                transfer.y += 2;
            }
            collision.gameObject.GetComponent<Transform>().position = transfer;
        }
    }
}
