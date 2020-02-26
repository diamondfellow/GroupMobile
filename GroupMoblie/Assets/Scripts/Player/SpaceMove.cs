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
    public GameObject Go;
    public Sprite goUp;
    public Sprite goDown;
    float move = 0;

    
    //public Text txt;
    // Start is called before the first frame update
    void Start()
    {
        fuel = 600;
        move = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(fuel > 1)
        {
            fuel -= move * (slider.value * fuelLoss);
            float thrustPower = slider.value;
            Vector2 moveDirection = new Vector2(movePoint.transform.position.x - transform.position.x, movePoint.transform.position.y - transform.position.y);
            moveDirection.Normalize();
            GetComponent<Rigidbody2D>().AddForce(moveDirection * move * thrustPower * Speed);
        }        
        UIfuel = Mathf.RoundToInt(fuel);
        if (!MainMenu.paused && SpaceHealth.alive){
            float rotation = joystick.Horizontal;
            float rotationChange = rotation * rotationSpeed;
            Vector3 transfer = GetComponent<Transform>().rotation.eulerAngles;
            transfer.z -= rotationChange;
            
            transform.eulerAngles = transfer;


        }
    }
    public void Thrust()
    {
        Go.GetComponent<Image>().sprite = goDown;
        move = 1f;
        GetComponent<ParticleSystem>().maxParticles = 500;
        ParticleSystem foo = GetComponent<ParticleSystem>();
        var shape = foo.shape;
        shape.angle = 4;
    }
    public void Stop()
    {
        Go.GetComponent<Image>().sprite = goUp;
        move = 0f;
        GetComponent<ParticleSystem>().maxParticles = 2;
        ParticleSystem foo = GetComponent<ParticleSystem>();
        var shape = foo.shape;
        shape.angle = 1;
    }

}
