using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BrownDoors : MonoBehaviour
{
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
           
            SceneManager.LoadScene("BattleRandomRoom") ;
            PlayerPrefs.SetString("Scene", "BattleRandomRoom");

        }
    }
}
