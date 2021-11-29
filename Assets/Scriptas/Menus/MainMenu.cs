using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour
{
    public GameObject interlude1;
    public GameObject canvas;
    public GameObject helpMenu;

    public Button contGame;

    public GameObject fog;
    public GameObject ini;
    public Animator anim;

    public string levels;
    public float healthd;

    AudioSource[] audioSources;
    AudioSource buttonPressed, explosion;

    

    void Start()
    {
        healthd = PlayerPrefs.GetFloat("health", 100f);
        levels = PlayerPrefs.GetString("Scene", "StartRoom");
        Debug.Log(levels);

        if (healthd <= 0 || levels == "StartRoom")
        {
            
            contGame.interactable = false;
        }
        

        audioSources = GetComponents<AudioSource>();
        buttonPressed = audioSources[0];
        explosion = audioSources[1];



        anim = fog.GetComponent<Animator>();
        Time.timeScale = 1;
        interlude1.SetActive(false);
        helpMenu.SetActive(false);
        canvas.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void NewGame()
    {
        buttonPressed.Play();
        PlayerPrefs.DeleteAll();
        Time.timeScale = 1;
        StartCoroutine(Timer());
       
    }
   
    public void ContinueGame()
    {
        buttonPressed.Play();
        Time.timeScale = 1;
        StartCoroutine(Timer2());
       
    }

    public void HelpMenu()
    {
        buttonPressed.Play();
        canvas.SetActive(false);
        helpMenu.SetActive(true);
    }
    public IEnumerator Timer() 
    {
        canvas.SetActive(false);
        ini.SetActive(false);
        anim.SetBool("Pressed", true);
        yield return new WaitForSeconds(3.5f);
        interlude1.SetActive(true);
        explosion.Play();
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("StartRoom");
        PlayerPrefs.SetString("Scene", "StartRoom");
    }
    public IEnumerator Timer2()
    {
        canvas.SetActive(false);
        ini.SetActive(false);
        anim.SetBool("Pressed", true);
        yield return new WaitForSeconds(3.5f);
        levels = PlayerPrefs.GetString("Scene", "StartRoom");
      
        SceneManager.LoadScene(levels);
       
    }
    public void ResumeButton()
    {
        buttonPressed.Play();
        helpMenu.SetActive(false);
        canvas.SetActive(true);
    }
    public void ExitButton()
    {
        buttonPressed.Play();
        Application.Quit();
    }
}
