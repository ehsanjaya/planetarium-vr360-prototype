using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour
{
    public float Time;
    public GameObject player;
    public GameObject point;
    public Text textDistance;
    public Text textTime;
    public ControlPlayerMobile controlPlayerMobile = new ControlPlayerMobile();
    public ControlPlayer controlPlayer = new ControlPlayer();
    public LineRenderer lr;
    public bool isDrawing = false;
    public string namePlanet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(point.transform.position, player.transform.position);
        textDistance.text = "Distance: Player To " + point.name + ": " + distance + " KM";
        if (SystemInfo.deviceType == DeviceType.Handheld) Time = distance / controlPlayerMobile.speedMove;
        if (SystemInfo.deviceType == DeviceType.Desktop) Time = distance / controlPlayer.speedMove;
        textTime.text = "Time: " + Time + " Minute";
        if (isDrawing == true)
        {
            point = GameObject.Find(namePlanet.ToString());
            lr.positionCount = 2;
            lr.SetPosition(0, new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z));
            lr.SetPosition(1, new Vector3(point.transform.position.x, point.transform.position.y, point.transform.position.z));
        }
        else
        {
            lr.positionCount = 0;
        }
    }
}
