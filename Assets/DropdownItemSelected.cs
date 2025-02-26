using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownItemSelected : MonoBehaviour
{
    Dropdown dropdown;
    public ControlPlayerMobile controlPlayerMobile = new ControlPlayerMobile();
    public ControlPlayer controlPlayer = new ControlPlayer();
    public Distance distance = new Distance();
    public GameObject textDistance;
    public GameObject textTime;
    public RawImage rawImage;
    public Texture[] textures;
    public Text textNamePlanet;
    string[] namePlanets = { "---------------", "Sun", "Mercury", "Venus", "Earth", "Moon", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune", "Pluto" };
    // Start is called before the first frame update
    void Start()
    {
        dropdown = GetComponent<Dropdown>();
        textDistance.SetActive(false);
        textTime.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MovementDropdown()
    {
        if (dropdown.value == 0)
        {
            controlPlayerMobile.movementAxis = "All Axis";
            controlPlayer.movementAxis = "All Axis";
        }
        else if (dropdown.value == 1)
        {
            controlPlayerMobile.movementAxis = "X Axis";
            controlPlayer.movementAxis = "X Axis";
        }
        else if (dropdown.value == 2)
        {
            controlPlayerMobile.movementAxis = "Y Axis";
            controlPlayer.movementAxis = "Y Axis";
        }
    }
    public void RotationDropdown()
    {
        if (dropdown.value == 0)
        {
            controlPlayerMobile.rotationAxis = "All Axis";
            controlPlayer.rotationAxis = "All Axis";
        }
        else if (dropdown.value == 1)
        {
            controlPlayerMobile.rotationAxis = "X Axis";
            controlPlayer.rotationAxis = "X Axis";
        }
        else if (dropdown.value == 2)
        {
            controlPlayerMobile.rotationAxis = "Y Axis";
            controlPlayer.rotationAxis = "Y Axis";
        }
    }

    public void PlanetDropdown()
    {
        if (dropdown.value == 0)
        {
            textDistance.SetActive(false);
            textTime.SetActive(false);
            distance.isDrawing = false;
            distance.namePlanet = "None";
            textNamePlanet.text = namePlanets[0];
        }
        else
        {
            textDistance.SetActive(true);
            textTime.SetActive(true);
            distance.isDrawing = true;
            distance.namePlanet = dropdown.options[dropdown.value].text;
            rawImage.texture = textures[dropdown.value];
            textNamePlanet.text = namePlanets[dropdown.value];
        }
    }
}
