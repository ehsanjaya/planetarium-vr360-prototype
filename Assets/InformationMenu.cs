using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class InformationMenu : MonoBehaviour
{
    public string title = "Title";
    [TextArea]
    [SerializeField]
    public string description = "This is a description... :)";
    public GameObject informationMenuUI;
    public Text textTitleUI;
    public Text textDescriptionUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Resume();
    }

    // Update is called once per frame
    void Update()
    {
        textTitleUI.text = title;
        textDescriptionUI.text = description;
    }

    public void Resume()
    {
        if (SystemInfo.deviceType == DeviceType.Desktop)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        informationMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Pause()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        informationMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }
}
