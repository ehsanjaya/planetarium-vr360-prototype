using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ellipse : MonoBehaviour
{
    public GameObject player;
    public Transform point;
    public float direction;
    public float step;
    public float size;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        step = direction;
    }

    // Update is called once per frame
    // Copy this -> player.transform.position = new Vector3(); <-
    void Update()
    {
        float r1 = size * 5;
        float r2 = size * 4;
        player.transform.position = new Vector3(
            point.position.x + Mathf.Sin(step) * r1, 
            3.15f, 
            point.position.z + Mathf.Cos(step) * r2
        );
        step += speed * Time.timeScale;
        if (step >= 360)
        {
            step = direction;
        }
    }
}
