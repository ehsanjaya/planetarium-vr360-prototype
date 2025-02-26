using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    public Transform player;
    public float speedRotation;
    public float speedMove;
    public Vector2 turn;
    public ParticleSystem particleSystem;
    public AudioSource audio;
    public string movementAxis = "All Axis";
    public string rotationAxis = "All Axis";
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SystemInfo.deviceType == DeviceType.Desktop)
        {
            turn.x += Input.GetAxis("Mouse X") * speedRotation * Time.timeScale;
            turn.y += Input.GetAxis("Mouse Y") * speedRotation * Time.timeScale;
            float x = Input.GetAxis("Horizontal") * speedMove * Time.timeScale;
            float z = Input.GetAxis("Vertical") * speedMove * Time.timeScale;

            if (movementAxis == "All Axis") transform.Translate(x, 0, z);
            else if (movementAxis == "X Axis") transform.Translate(x, 0, 0);
            else if (movementAxis == "Y Axis") transform.Translate(0, 0, z);

            if (rotationAxis == "All Axis") transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
            else if (rotationAxis == "X Axis") transform.localRotation = Quaternion.Euler(-turn.y, 0, 0);
            else if (rotationAxis == "Y Axis") transform.localRotation = Quaternion.Euler(0, turn.x, 0);

            if (x != 0f || z != 0f)
            {
                particleSystem.Play();
                audio.pitch = 1f;
            }
            else
            {
                particleSystem.Stop();
                audio.pitch = 0f;
            }
        }
    }

    public void MouseSensivity(float speed)
    {
        //Change the speed rotation
        speedRotation = speed;
    }
    public void SpeedMove(float speed)
    {
        //Change the speed move
        speedMove = speed;
    }
    public void ResetRotation()
    {
        //Reset the rotation
        transform.rotation = Quaternion.Euler(0f, 0f, 0f);
    }
}
