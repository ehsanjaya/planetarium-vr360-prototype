using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPause = true;
    public GameObject pauseMenuUI;
    public GameObject settingsMenuUI;
    public GameObject controlsMenuUI;
    // Start is called before the first frame update
    void Start()
    {
        Resume();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(gameIsPause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        if (SystemInfo.deviceType == DeviceType.Desktop)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        pauseMenuUI.SetActive(false);
        settingsMenuUI.SetActive(false);
        controlsMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPause = false;
    }

    public void Pause()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        pauseMenuUI.SetActive(true);
        settingsMenuUI.SetActive(false);
        controlsMenuUI.SetActive(false);
        Time.timeScale = 0f;
        gameIsPause = true;
    }

    public void Settings()
    {
        pauseMenuUI.SetActive(true);
        settingsMenuUI.SetActive(true);
        controlsMenuUI.SetActive(false);
    }
    public void Controls()
    {
        pauseMenuUI.SetActive(true);
        settingsMenuUI.SetActive(false);
        controlsMenuUI.SetActive(true);
    }
    public void Exit()
    {
        settingsMenuUI.SetActive(false);
        pauseMenuUI.SetActive(true);
        controlsMenuUI.SetActive(false);
        Time.timeScale = 0f;
        gameIsPause = true;
    }
    public void QuitApplication()
    {
        SceneManager.LoadScene("Intro");
    }
}
