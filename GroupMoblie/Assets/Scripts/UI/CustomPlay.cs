using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CustomPlay : MonoBehaviour
{
    public static bool isDefault = true; 

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
        SettingsChange();
    }
    public void SettingsChange()
    {
        float nop = NumOfPlanets.value;
        NumOfPlanetsT.text = ("" + Mathf.RoundToInt(nop));
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

        float gs = GravityStrength.value;
        GravityStrengthT.text = ("" + gs);
        PlayerPrefs.SetFloat("GravityStrength", gs);

        float tp = ThrustPower.value;
        ThrustPowerT.text = ("" + tp);
        PlayerPrefs.SetFloat("ThrustPower", tp);

        float rs = RotationSpeed.value;
        RotationSpeedT.text = ("" + rs);
        PlayerPrefs.SetFloat("RotationSpeed", rs);

        float hpmr = HomePlanetMetalRequirent.value;
        HomePlanetMetalRequirentT.text = ("" + Mathf.RoundToInt(hpmr));
        PlayerPrefs.SetInt("MetalRequirement", Mathf.RoundToInt(hpmr));

        float mh = MaxHealth.value;
        MaxHealthT.text = ("" + Mathf.RoundToInt(mh));
        PlayerPrefs.SetInt("MaxHealth", Mathf.RoundToInt(mh));
    }
    public void Default()
    {
        isDefault = true;
        NumOfPlanets.value = 20;
        MaxFuel.value = 750;
        MaxOxygen.value =200;
        MaxFood.value = 30;
        MaxMetal.value = 300;
        GravityStrength.value = 1.50f;
        ThrustPower.value = 3;
        RotationSpeed.value = 3;
        HomePlanetMetalRequirent.value = 1000;
        MaxHealth.value = 100;
        SettingsChange();
        SceneManager.LoadScene(0);
    }
}
