using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;
            ControlPlayerMobile controlPlayerMobile = new ControlPlayerMobile();
            if (Physics.Raycast(ray, out hit))
            {
                if(hit.transform.tag == "Handle")
                { 
                    
                }
            }
        }
    }
}
