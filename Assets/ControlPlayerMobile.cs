using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayerMobile : MonoBehaviour
{
    private Touch touch;
    public float speedRotation;
    public float speedMove;
    [SerializeField] private FixedJoystick joystickMove;
    [SerializeField] private FixedJoystick joystickRotate;
    public ParticleSystem particleSystem;
    public AudioSource audio;
    public string movementAxis = "All Axis";
    public string rotationAxis = "All Axis";
    public GameObject fixedJoystickMove;
    public GameObject fixedJoystickRotate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SystemInfo.deviceType == DeviceType.Handheld)
        {
            fixedJoystickMove.SetActive(true);
            fixedJoystickRotate.SetActive(true);
            if (movementAxis == "All Axis") transform.Translate(joystickMove.Horizontal * speedMove * Time.timeScale, 0f, joystickMove.Vertical * speedMove * Time.timeScale);

            else if (movementAxis == "X Axis") transform.Translate(joystickMove.Horizontal * speedMove * Time.timeScale, 0f, 0f);
            else if (movementAxis == "Y Axis") transform.Translate(0f * speedMove * Time.timeScale, 0f, joystickMove.Vertical * speedMove * Time.timeScale);

            if (rotationAxis == "All Axis") transform.Rotate(-joystickRotate.Vertical * speedRotation, joystickRotate.Horizontal * speedRotation * Time.timeScale, 0f);
            else if (rotationAxis == "X Axis") transform.Rotate(0f * speedRotation * Time.timeScale, joystickRotate.Horizontal * speedRotation * Time.timeScale, 0f);
            else if (rotationAxis == "Y Axis") transform.Rotate(-joystickRotate.Vertical * speedRotation * Time.timeScale, 0f, 0f);

            if (joystickMove.Horizontal != 0f || joystickMove.Vertical != 0f)
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
        else
        {
            fixedJoystickMove.SetActive(false);
            fixedJoystickRotate.SetActive(false);
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
