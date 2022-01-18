using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeDectect : MonoBehaviour
{
    string tag;
   
    public  float vida;
    public PlayerStats playerScript;

    public bool isBurning;

    private Renderer rend;
    public Color originalColor;
    public Color selectedColor = Color.red;

    public VenusDPS ven;
    void Start()
    {
        tag = this.gameObject.tag;
        vida = 30;
        isBurning = false;
        ven = FindObjectOfType<VenusDPS>();
       // rend = GetComponent<Renderer>();
       // rend = GetComponentInParent(typeof(Renderer)) as Renderer;
        rend = gameObject.GetComponentInParent<Renderer>();
        originalColor = rend.material.color;
        playerScript = FindObjectOfType<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ven.isBurning == true)
        {
            StartCoroutine(ven.VenusDPs());
            
        }

        /*if (vida <= 0)
        {
            Destroy(gameObject, 1);
        }*/
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
                    ven.vida -= 20;
                
                    if (playerScript.venus == 1)
                    {
                        ven.isBurning = true;

                    }
                }
                else
                {
                    ven.vida -= 10;

                    if (playerScript.venus == 1)
                    {
                        ven.isBurning = true;

                    }
                }

            }
            else
            {
                if (playerScript.mercury == 1)
                {
                    ven.vida -= 10;

                    if (playerScript.venus == 1)
                    {
                        ven.isBurning = true;

                    }
                }
                else
                {
                    ven.vida -= 5;
                    if (playerScript.venus == 1)
                    {
                        ven.isBurning = true;

                    }
                }

            }
            
        }
        if (Collider2D.tag == "BlueP")
        {
            Debug.Log("Herido");

            if (tag.Equals("FireDogo"))
            {
                if (playerScript.mercury == 1)
                {
                    vida -= 20;

                    if (playerScript.venus == 1)
                    {
                        ven.isBurning = true;

                    }
                }
                else
                {
                    vida -= 20;

                    if (playerScript.venus == 1)
                    {
                        ven.isBurning = true;

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
                        ven.isBurning = true;

                    }
                }
                else
                {
                    vida -= 5;

                    if (playerScript.venus == 1)
                    {
                        ven.isBurning = true;

                    }
                }
            }

        }
        else
        {
            

        }
        if (Collider2D.tag == "PurpleP")
        {
            Debug.Log("Herido");

            if (tag.Equals("WaterDogo"))
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
        if (Collider2D.tag == "GreenP")
        {
            Debug.Log("Herido");

            if (tag.Equals("AirDogo"))
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
        if (Collider2D.tag == "BlackP")
        {
            Debug.Log("Herido");
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
  

    private void OnTriggerExit2D(Collider2D Collider2D)
    {
      

    }
  /*  public IEnumerator VenusDPS()
    {

        // recibe un porcentaje de daño de forma pasiva durante 3 segundos
       
        rend.material.color = selectedColor;
        vida -= 0.5f * Time.deltaTime;
        Debug.Log("Llegas?");
        yield return new WaitForSeconds(3f);
        rend.material.color = originalColor;
        isBurning = false;



    }*/
}
