using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererEllipse : MonoBehaviour
{
    public LineRenderer lr;
    public Transform point;
    public float direction;
    public float step;
    public float size;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float r1 = size * 5;
        float r2 = size * 4;
        step = direction;
        lr.positionCount = 0;
        for (int i = 0; i <= 360; i++)
        {
            lr.positionCount++;
            lr.SetPosition(i, new Vector3(
                point.position.x + Mathf.Sin(step) * r1,
                3.146603f,
                point.position.z + Mathf.Cos(step) * r2
                ));
            step += speed;
        }
    }
}
