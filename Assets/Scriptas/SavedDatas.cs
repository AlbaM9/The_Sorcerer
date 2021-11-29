using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SavedDatas : MonoBehaviour
{
    public PlayerStats saveData;
   
    private void Awake()
    {
        
        saveData = FindObjectOfType<PlayerStats>();

       



    }
    void Start()
    {
        LoadData();

    }

    // Update is called once per frame
    void Update()
    {

        if (saveData.playerHealth <= 0)
        {
            PlayerPrefs.DeleteAll();
            
        }
       
        SaveDatas();
       
    }
    public void SaveDatas() 
    {

        PlayerPrefs.SetFloat("health", saveData.playerHealth);
        PlayerPrefs.SetInt("airSaved", saveData.airElement);
        PlayerPrefs.SetInt("waterSaved", saveData.waterElement);
        PlayerPrefs.SetInt("fireSaved", saveData.fireElement);
        PlayerPrefs.SetInt("earthSaved", saveData.earthElement);
        PlayerPrefs.SetInt("saturnSaved", saveData.saturn);
        PlayerPrefs.SetInt("uranusSaved", saveData.uranus);
        PlayerPrefs.SetInt("mercurySaved", saveData.mercury);
        PlayerPrefs.SetInt("venusSaved", saveData.venus);
        PlayerPrefs.SetInt("limiter", saveData.pULimiter);
        PlayerPrefs.SetInt("pu1", saveData.pu1);
        PlayerPrefs.SetInt("pu2", saveData.pu2);
        PlayerPrefs.SetInt("pu3", saveData.pu3);
        PlayerPrefs.SetInt("pu4", saveData.pu4);


        PlayerPrefs.Save();
        Debug.Log("salvado");
    }

    public void LoadData() 
    {

        saveData.playerHealth = PlayerPrefs.GetFloat("health", 100f);
        saveData.airElement = PlayerPrefs.GetInt("airSaved");
        saveData.waterElement = PlayerPrefs.GetInt("waterSaved");
        saveData.fireElement = PlayerPrefs.GetInt("fireSaved");
        saveData.earthElement = PlayerPrefs.GetInt("earthSaved");
        saveData.saturn = PlayerPrefs.GetInt("saturnSaved");
        saveData.uranus = PlayerPrefs.GetInt("uranusSaved");
        saveData.mercury = PlayerPrefs.GetInt("mercurySaved");
        saveData.venus = PlayerPrefs.GetInt("venusSaved");
        saveData.pULimiter = PlayerPrefs.GetInt("limiter");
        saveData.pu1 = PlayerPrefs.GetInt("pu1");
        saveData.pu2 = PlayerPrefs.GetInt("pu2");
        saveData.pu3 = PlayerPrefs.GetInt("pu3");
        saveData.pu4 = PlayerPrefs.GetInt("pu4");
       

    }

    
}   
