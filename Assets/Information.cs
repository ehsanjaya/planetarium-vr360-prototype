using UnityEngine;
using UnityEditor;
using System.Collections;
using System.ComponentModel;
using System;

public class Information : MonoBehaviour
{
    public static bool isCloseDistance = false;
    public bool isShowInformation = false;
    public string title = "Title";
    [TextArea]
    [SerializeField]
    public string description = "This is a description... :)";
    public float distanceRange;
    public GameObject planet;
    public GameObject point; 
    public InformationMenu informationMenu = new InformationMenu();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(point.transform.position, planet.transform.position);
        if (isCloseDistance == false)
        {
            if (distance < distanceRange)
            {
                informationMenu.title = title;
                informationMenu.description = description;
                informationMenu.Pause();
                isCloseDistance = true;
                isShowInformation = true;
                Time.timeScale = 0f;
            }
        }
        else
        {
            if (distance > distanceRange && isShowInformation == true)
            {
                informationMenu.Resume();
                isCloseDistance = false;
                isShowInformation = false;
                Time.timeScale = 1f;
            }
        }
    }
}
