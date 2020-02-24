using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SpaceHealth : MonoBehaviour
{
    public float damageModifier;
    public float maxSpeed;
    public int maxHp;
    public static int hp;
    public static int oxygen;
    public static int food;
    public static int metal;
    public static bool alive;
    float velocityY;
    float velocityX;

    float Otimer;
    float Ftimer;
    float Mtimer;
    float FUtimer;
    float VELOtimer;
    float hurtTimer;
    float deathtimer;

    public Canvas Interface;
    public Canvas Death;
    public Text deathText;
    public Image Fade;
    // Start is called before the first frame update
    void Start()
    {
        alive = true;
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
            food -= 1;
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
        deathtimer += Time.deltaTime;
        if(SpaceMove.UIfuel >= 1)
        {
            FUtimer = 0;
            
        }       
        if( hp <= 0)
        {
            if (alive)
            {
                deathtimer = 0;
            }
            alive = false;
            Interface.enabled = false;
            Death.enabled = true;
            deathText.text = "Your hull intergity is 0, your fuel tanks rupture casuing a massive fireball";
        }
        else if (oxygen <= 0)
        {
            if (alive)
            {
                deathtimer = 0;
            }
            alive = false;
            Interface.enabled = false;
            Death.enabled = true;
            deathText.text = "With no oxygen everything fades to balck as you lose conciocness";
        }
        else if(food <= 0)
        {
            if (alive)
            {
                deathtimer = 0;
            }
            alive = false;
            Interface.enabled = false;            
            deathText.text = "With no food you lose cognitive thought and stare at the darkness unitl it stares back";
        }
        else if (FUtimer > 5)
        {
            if (alive)
            {
                deathtimer = 0;
            }           
            alive = false;
            Interface.enabled = false;
            Death.enabled = true;
            deathText.text = "With no fuel you drift endlessly into the nowhere";
        }
        if(hurtTimer > .3 && hurtTimer < .6)
        {
            Color color = GetComponent<SpriteRenderer>().color;
            color.g = 255;
            color.b = 255;
            GetComponent<SpriteRenderer>().color = color;
        }
        if (deathtimer > 5 && !alive) 
        {
            //Debug.Log("Work please");
            Fade.GetComponent<Animator>().SetTrigger("fade");
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
    
    public void Explosion()
    {

    }
}
