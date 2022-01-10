using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeDectect : MonoBehaviour
{
    string tag;
   
    public  float vida;
    public PlayerStats playerScript;

    public bool isBurning = false;

    private Renderer rend;
    private Color originalColor;
    public Color selectedColor = Color.red;

    void Start()
    {
        tag = this.gameObject.tag;
        vida = 30;

        rend = GetComponent<Renderer>();
        originalColor = rend.material.color;
        playerScript = FindObjectOfType<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isBurning == true)
        {
            StartCoroutine(VenusDPS());
        }
    }
    private void OnTriggerEnter2D(Collider2D Collider2D)
    {
        if (Collider2D.tag == "RedP")
        {
            Debug.Log("Herido");

            if (tag.Equals("EarthDogo")) // tag == "tierra"
            {
                
                if (playerScript.mercury == 1) 
                {
                    vida -= 20;
                
                    if (playerScript.venus == 1)
                    {
                        isBurning = true;

                    }
                }
                else
                {
                    vida -= 10;

                    if (playerScript.venus == 1)
                    {
                        isBurning = true;

                    }
                }

            }
            else
            {
                if (playerScript.mercury == 1)
                {
                    vida -= 10;

                    if (playerScript.venus == 1)
                    {
                        isBurning = true;

                    }
                }
                else
                {
                    vida -= 5;
                    if (playerScript.venus == 1)
                    {
                        isBurning = true;

                    }
                }

            }
            
        }
        if (Collider2D.tag == "BlueP")
        {
            Debug.Log("Herido");

            if (tag.Equals("FireDogo"))
            {
                vida -= 10;

                if (playerScript.venus == 1)
                {
                    isBurning = true;

                }
            }
            else
            {
                vida -= 5;

                if (playerScript.venus == 1)
                {
                    isBurning = true;

                }
            }

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
            Debug.Log("Herido");

            if (tag.Equals("FireDogo"))
            {
                vida -= 5;

                if (playerScript.venus == 1)
                {
                    isBurning = true;

                }
            }
            else
            {
                vida -= 5;

                if (playerScript.venus == 1)
                {
                    isBurning = true;

                }
            }
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
    public IEnumerator VenusDPS()
    {

        // recibe un porcentaje de daño de forma pasiva durante 3 segundos
        
        rend.material.color = selectedColor;
        vida -= 0.5f * Time.deltaTime;
        yield return new WaitForSeconds(3f);
        rend.material.color = originalColor;
        isBurning = false;



    }
}
