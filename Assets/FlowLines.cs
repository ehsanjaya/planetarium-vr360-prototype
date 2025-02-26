using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowLines : MonoBehaviour
{
    public Material material;
    public Transform point;
    public Transform position;
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
        
    }
    //enable the gizmos to true
    void OnDrawGizmos()
    {
        RenderLines(new Vector3[0]);
    }
    void RenderLines(Vector3[] points)
    {
        GL.Begin(GL.LINES);
        float r1 = size * 5;
        float r2 = size * 4;
        step = direction;
        material.SetPass(0);
        GL.Color(material.color);
        GL.Vertex3(position.position.x, position.position.y, position.position.z);
        for (int i = 0; i <= 360; i++)
        {
            GL.Vertex3(
                point.position.x + Mathf.Sin(step) * r1,
                3.15f,
                point.position.z + Mathf.Cos(step) * r2
                );
            step += speed;
        }
        GL.End();
    }
}
