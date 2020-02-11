using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SpaceMove : MonoBehaviour
{
    public float Speed;
    public static int UIfuel;
    public static float fuel;
    public Text txt;
    // Start is called before the first frame update
    void Start()
    {
        fuel = 1000;
    }

    // Update is called once per frame
    void Update()
    {
        UIfuel = Mathf.RoundToInt(fuel);
        if (Input.GetMouseButton(0) && UIfuel >= 1 && !MainMenu.paused)
        {
            fuel -= .2f;
            Vector3 mousePosition1 = Input.mousePosition;
            mousePosition1 = Camera.main.ScreenToWorldPoint(mousePosition1);
            mousePosition1.z = transform.position.z;
            Vector2 MoveDirection = new Vector2(mousePosition1.x -transform.position.x, mousePosition1.y - transform.position.y);
            transform.up = (mousePosition1 - transform.position) * 1;
            MoveDirection.Normalize();
            GetComponent<Rigidbody2D>().AddForce(new Vector2(MoveDirection.x* Speed, MoveDirection.y * Speed));
            txt.text = "" + new Vector2(MoveDirection.x * Speed, MoveDirection.y * Speed);
        }
    }
}
