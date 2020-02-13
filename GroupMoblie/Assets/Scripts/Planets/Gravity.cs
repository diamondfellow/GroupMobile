using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    GameObject player;
    public float gravityStrength;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Vector2 moveDirection = new Vector2(transform.position.x - player.transform.position.x,
                transform.position.y - player.transform.position.y);
            moveDirection.Normalize();
            player.GetComponent<Rigidbody2D>().AddForce(moveDirection * gravityStrength *
                GetComponent<Transform>().localScale);

        }
    }
}
