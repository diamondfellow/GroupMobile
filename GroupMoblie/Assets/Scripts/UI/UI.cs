using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text hp;
    public Text metal;
    public Text fuel;
    public Text food;
    public Text oxygen;
    public Text homePlanet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hp.text = ("HEALTH: " + SpaceHealth.hp);
        metal.text = ("METAL: " + SpaceHealth.metal);
        fuel.text = ("FUEL: " + SpaceMove.UIfuel);
        food.text = ("FOOD: " + SpaceHealth.food);
        oxygen.text = ("OXYGEN: " + SpaceHealth.oxygen);
        //homePlanet.text = ("Home Planet Metal: " + HomeP.homeMetal);
    }
}
