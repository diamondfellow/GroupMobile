using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SpaceMove : MonoBehaviour
{
    public float Speed;
    public float fuelLoss;
    public float rotationSpeed;
    public static int UIfuel;
    public static float fuel;
    public Slider slider;
    public Joystick joystick;
    public GameObject movePoint;
    float move = 0;
    //public Text txt;
    // Start is called before the first frame update
    void Start()
    {
        fuel = 1000;
        move = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        fuel -= move*(slider.value * fuelLoss);
        UIfuel = Mathf.RoundToInt(fuel);
        if (!MainMenu.paused){
            float rotation = joystick.Horizontal;
            float rotationChange = rotation * rotationSpeed;
            Vector3 transfer = GetComponent<Transform>().rotation.eulerAngles;
            transfer.z -= rotationChange;
            Debug.Log(transfer);
            transform.eulerAngles = transfer;

            float thrustPower = slider.value;
            Vector2 moveDirection = new Vector2(movePoint.transform.position.x - transform.position.x, movePoint.transform.position.y - transform.position.y);
            moveDirection.Normalize();
            GetComponent<Rigidbody2D>().AddForce(moveDirection * move * thrustPower * Speed);
        }
    }
    public void Thrust()
    {
        move = 1f;
        GetComponent<ParticleSystem>().maxParticles = 500;
        ParticleSystem foo = GetComponent<ParticleSystem>();
        var shape = foo.shape;
        shape.angle = 4;
    }
    public void Stop()
    {
        move = 0f;
        GetComponent<ParticleSystem>().maxParticles = 2;
        ParticleSystem foo = GetComponent<ParticleSystem>();
        var shape = foo.shape;
        shape.angle = 1;
    }

}
