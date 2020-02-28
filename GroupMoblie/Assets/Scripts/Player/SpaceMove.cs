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

    bool playEngine;
    public AudioClip engine;
    public AudioSource Sound;
    //public Text txt;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(PlayerPrefs.GetInt("MaxFuel"));
        rotationSpeed = PlayerPrefs.GetFloat("RotationSpeed");
        Speed = PlayerPrefs.GetFloat("ThrustPower");
        fuel = PlayerPrefs.GetFloat("MaxFuel");
        move = 0f;
        playEngine = false;
    }

    // Update is called once per frame
    void Update()
    {
        UIfuel = Mathf.RoundToInt(fuel);
        if (playEngine && !Sound.isPlaying)
        {
            Sound.PlayOneShot(engine);
        }
        if(fuel >= 1)
        {
            fuel -= move * (slider.value * fuelLoss);
            float thrustPower = slider.value;
            Vector2 moveDirection = new Vector2(movePoint.transform.position.x - transform.position.x, movePoint.transform.position.y - transform.position.y);
            moveDirection.Normalize();
            GetComponent<Rigidbody2D>().AddForce(moveDirection * move * thrustPower * Speed);
        }        
        
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
        playEngine = true;
        Go.GetComponent<Image>().sprite = goDown;
        move = 1f;
        GetComponent<ParticleSystem>().maxParticles = 500;
        ParticleSystem foo = GetComponent<ParticleSystem>();
        var shape = foo.shape;
        shape.angle = 4;
    }
    public void Stop()
    {
        Sound.Stop();
        playEngine = false;
        Go.GetComponent<Image>().sprite = goUp;
        move = 0f;
        GetComponent<ParticleSystem>().maxParticles = 2;
        ParticleSystem foo = GetComponent<ParticleSystem>();
        var shape = foo.shape;
        shape.angle = 1;
    }

}
