using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject statusUI;
    public GameObject helpMenu;


    AudioSource[] audioSources;
    AudioSource buttonPressed;

    public string levels;
    public float life;
    void Start()
    {
        audioSources = GetComponents<AudioSource>();
        buttonPressed = audioSources[0];
        

        pauseMenu.SetActive(false);
        helpMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            Time.timeScale = 0;
            statusUI.SetActive(false);
            pauseMenu.SetActive(true);
        }
    }
    public void ResumeButton()
    {
        buttonPressed.Play();
        Time.timeScale = 1;
        statusUI.SetActive(true);
        pauseMenu.SetActive(false);
        helpMenu.SetActive(false);
    }

    public void HelpMenu() 
    {
        buttonPressed.Play();
        pauseMenu.SetActive(false);
        helpMenu.SetActive(true);
    }
    public void MainMenu()
    {
        levels = PlayerPrefs.GetString("Scene", "StartRoom");
      
      

        buttonPressed.Play();
        SceneManager.LoadScene("MainMenu");
    }
}

