using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeDectect : MonoBehaviour
{
    string tag;
   
    public  float vida;

    void Start()
    {
        tag = this.gameObject.tag;
        vida = 30;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D Collider2D)
    {
        if (Collider2D.tag == "RedP")
        {
            Debug.Log("Herido");

            if (tag.Equals("EarthDogo")) // tag == "tierra"
            {
                vida -= 10;
            }
            else
            {
                vida-= 5;
            }
        }
        if (Collider2D.tag == "BlueP")
        {
            Debug.Log("Herido");

        }
        if (Collider2D.tag == "PurpleP")
        {
            Debug.Log("Herido");
        }
        if (Collider2D.tag == "GreenP")
        {
            Debug.Log("Herido");
        }
        if (Collider2D.tag == "BlackP")
        {
            Debug.Log("Herido");
        }

    }

    private void OnTriggerExit2D(Collider2D Collider2D)
    {
        if (Collider2D.tag == "RedP")
        {
            
        }
        if (Collider2D.tag == "BlueP")
        {
            
        }
        if (Collider2D.tag == "PurpleP")
        {
            
        }
        if (Collider2D.tag == "GreenP")
        {
            
        }
        if (Collider2D.tag == "BlackP")
        {
            
        }

    } 
   
}
