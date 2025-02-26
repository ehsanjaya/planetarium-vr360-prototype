using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetNameDevice : MonoBehaviour
{
    public Text textDevice;
    public Text textControl;
    public string controlName;
    // Start is called before the first frame update
    void Start()
    {
        textDevice.text = "Name Device: None";
        textControl.text = "Device Control: None";
    }

    // Update is called once per frame
    void Update()
    {
        if (SystemInfo.deviceType == DeviceType.Desktop) controlName = "Keyboard";
        else if (SystemInfo.deviceType == DeviceType.Handheld) controlName = "Touch Hand";
        textDevice.text = "Name Device: " + SystemInfo.deviceName;
        textControl.text = "Device Control: " + controlName;
    }
}
