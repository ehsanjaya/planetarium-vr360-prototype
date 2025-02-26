using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlanet : MonoBehaviour
{
    public Transform player;
    public float speedX;
    public float speedY;
    public float speedZ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player.Rotate(speedX, speedY, speedZ);
    }
}
