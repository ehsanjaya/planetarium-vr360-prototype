using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public Transform pointObj;
    public GameObject player;
    public float distance;
    public float direction;
    public float speed;
    public float x;
    public float y;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        x = pointObj.position.x + distance * Mathf.Sin(direction);
        y = pointObj.position.y + distance * Mathf.Cos(direction);
        direction += speed;
        player.transform.position = new Vector3(x, y, 0);
    }
}
