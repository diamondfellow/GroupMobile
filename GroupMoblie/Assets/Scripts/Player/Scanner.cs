using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scanner : MonoBehaviour
{
    public float scanRadius;
    public LayerMask scanLayers;
    public Text ScanText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Scan()
    {
        ScanText.text = "Scanned:";
        Collider2D[] scannedObjects = Physics2D.OverlapCircleAll(transform.position, scanRadius, scanLayers);
        foreach(Collider2D scanObject in scannedObjects)
        {
            if(scannedObjects == null)
            {
                ScanText.text = (ScanText.text + "No Planets within Range");
            }
            switch (scanObject.name)
            {
                case "Food(Clone)":
                    ScanText.text = (ScanText.text + "\n Planet:Food | Distance: " 
                        + scanObject.GetComponent<PlanetCheck>().Distance() 
                        + " | Gravity: " + scanObject.GetComponent<Gravity>().GravityCheck());
                    break;
                case "Oxygen(Clone)":
                    ScanText.text = (ScanText.text + "\n Planet:Oxygen | Distance: " 
                        + scanObject.GetComponent<PlanetCheck>().Distance() 
                        + " | Gravity: " + scanObject.GetComponent<Gravity>().GravityCheck());
                    break;
                case "Fuel(Clone)":
                     ScanText.text = (ScanText.text + "\n Planet:Fuel | Distance: " 
                        + scanObject.GetComponent<PlanetCheck>().Distance() 
                        + " | Gravity: " + scanObject.GetComponent<Gravity>().GravityCheck());
                    break;
                case "Metal(Clone)":
                     ScanText.text = (ScanText.text + "\n Planet:Metal | Distance: " 
                        + scanObject.GetComponent<PlanetCheck>().Distance() 
                        + " | Gravity: " + scanObject.GetComponent<Gravity>().GravityCheck());
                    break;
            } 
        }
    }
    public void OnDrawGizmosSelected()
    {
        Debug.Log("?");
        Gizmos.DrawWireSphere(transform.position, scanRadius);
    }


}
