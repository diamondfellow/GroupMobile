using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomPlay : MonoBehaviour
{
    public Slider NumOfPlanets;
    //public Slider ScaleOfPlanets;
    public Slider MaxFuel;
    public Slider MaxOxygen;
    public Slider MaxFood;
    public Slider MaxMetal;
    public Slider GravityStrength;
    public Slider ThrustPower;
    public Slider RotationSpeed;
    public Slider HomePlanetMetalRequirent;
    public Slider MaxHealth;

    public Text NumOfPlanetsT;
    //public Text ScaleOfPlanetsT;
    public Text MaxFuelT;
    public Text MaxOxygenT;
    public Text MaxFoodT;
    public Text MaxMetalT;
    public Text GravityStrengthT;
    public Text ThrustPowerT;
    public Text RotationSpeedT;
    public Text HomePlanetMetalRequirentT;
    public Text MaxHealthT;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        float nop = NumOfPlanets.value;
        NumOfPlanetsT.text = ("" +Mathf.RoundToInt(nop));  
        PlayerPrefs.SetInt("MaxPlanets", Mathf.RoundToInt(nop));

        float mf = MaxFuel.value;
        MaxFuelT.text = ("" + Mathf.RoundToInt(mf));
        PlayerPrefs.SetFloat("MaxFuel", mf);

        float mo = MaxOxygen.value;
        MaxOxygenT.text = ("" + Mathf.RoundToInt(mo));
        PlayerPrefs.SetInt("MaxOxygen", Mathf.RoundToInt(mo));

        float mfd = MaxFood.value;
        MaxFoodT.text = ("" + Mathf.RoundToInt(mfd));
        PlayerPrefs.SetInt("MaxFood", Mathf.RoundToInt(mfd));

        float mm = MaxMetal.value;
        MaxMetalT.text = ("" + Mathf.RoundToInt(mm));
        PlayerPrefs.SetInt("MaxMetal", Mathf.RoundToInt(mm));


    }
}
