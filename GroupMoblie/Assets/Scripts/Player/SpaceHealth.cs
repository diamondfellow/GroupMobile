using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceHealth : MonoBehaviour
{
    public float damageModifier;
    public float maxSpeed;
    public int maxHp;
    public static int hp;
    public static int oxygen;
    public static int food;
    public static int metal;
    float velocityY;
    float velocityX;

    float Otimer;
    float Ftimer;
    float Mtimer;
    float FUtimer;
    float VELOtimer;
    float hurtTimer;
    
    // Start is called before the first frame update
    void Start()
    {
        oxygen = 200;
        food = 50;
        metal = 0;
        hp = maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        if(VELOtimer > .1)
        {
            Vector2 velocity = GetComponent<Rigidbody2D>().velocity;
            velocity = new Vector2(Mathf.Abs(velocity.x), Mathf.Abs(velocity.y));
            velocityX = velocity.x;
            velocityY = velocity.y;
            VELOtimer = 0;
        }
        if(Otimer > 1)
        {
            oxygen -= 1;
            Otimer = 0;
        }
        if (Ftimer > 5)
        {
            food -= 2;
            Ftimer = 0;
        }
        if(Mtimer > 2 && hp < maxHp && metal > 0)
        {
            metal -= 1;
            hp += 1;
            Mtimer = 0;
        }
        Otimer += Time.deltaTime;
        Ftimer += Time.deltaTime;
        Mtimer += Time.deltaTime;
        FUtimer += Time.deltaTime;
        VELOtimer += Time.deltaTime;
        hurtTimer += Time.deltaTime;
        if(SpaceMove.UIfuel >= 1)
        {
            FUtimer = 0;
        }       
        if( hp <= 0 || oxygen <= 0 || food <= 0 || FUtimer > 5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if(hurtTimer > .3 && hurtTimer < .6)
        {
            Color color = GetComponent<SpriteRenderer>().color;
            color.g = 255;
            color.b = 255;
            GetComponent<SpriteRenderer>().color = color;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {

        if((velocityX + velocityY) > maxSpeed)
        {
            hurtTimer = 0;
            Color color = GetComponent<SpriteRenderer>().color;
            color.g = 0;
            color.b = 0;
            GetComponent<SpriteRenderer>().color = color;
            float damage = damageModifier * (velocityX + velocityY);
            int tDamage = (int) damage;
            hp -= tDamage;
        }
       
    }
}
