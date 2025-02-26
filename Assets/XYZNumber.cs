using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XYZNumber : MonoBehaviour
{
    public string name;
    public Transform position;
    public Text textX;
    public Text textY;
    public Text textZ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textX.text = name.ToString() + " X: " + transform.position.x;
        textY.text = name.ToString() + " Y: " + transform.position.y;
        textZ.text = name.ToString() + " Z: " + transform.position.z;
    }
}
