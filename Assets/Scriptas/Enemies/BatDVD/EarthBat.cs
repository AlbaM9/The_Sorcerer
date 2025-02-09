using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthBat : MonoBehaviour
{
    public ItemRoomDoors enemie;
    public Rigidbody2D rb;
    public PlayerStats playerScript;
    public Animator anim;
    public float lifeBat;
    public bool isBurning = false;

    public AudioSource dmg;

    private Renderer rend;
    private Color originalColor;
    public Color selectedColor = Color.red;

    void Start()
    {
        rend = GetComponent<Renderer>();
        originalColor = rend.material.color;

        enemie = FindObjectOfType<ItemRoomDoors>();
        lifeBat = 40;
        anim.SetBool("Damaged", false);
        playerScript = FindObjectOfType<PlayerStats>();
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (lifeBat <= 0)
        {
            anim.SetBool("Die", true);
            rb.velocity = transform.right * 0;
            rb.velocity = transform.up * 0;
            StartCoroutine(BatDead());
        }
        if (isBurning == true)
        {
            StartCoroutine(VenusDPS());
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("impaktao");

            if (playerScript.airElement == 1)
            {
                playerScript.playerHealth -= 10;
            }
            else
            {
                playerScript.playerHealth -= 5;
            }

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "GreenP")
        {
            anim.SetBool("Damaged", true);
            
            if (playerScript.mercury == 1)
            {
                lifeBat -= 10;
                if (playerScript.venus == 1)
                {
                    isBurning = true;

                }
            }
            else
            {
                lifeBat -= 5;
                if (playerScript.venus == 1)
                {
                    isBurning = true;

                }
            }
        }
        if (collision.gameObject.tag == "BlueP")
        {
            anim.SetBool("Damaged", true);
            
            if (playerScript.mercury == 1)
            {
                lifeBat -= 10;
                if (playerScript.venus == 1)
                {
                    isBurning = true;

                }
            }
            else
            {
                lifeBat -= 5;
                if (playerScript.venus == 1)
                {
                    isBurning = true;

                }
            }
        }
        if (collision.gameObject.tag == "PurpleP")
        {
            anim.SetBool("Damaged", true);
            
            if (playerScript.mercury == 1)
            {
                lifeBat -= 10;
                if (playerScript.venus == 1)
                {
                    isBurning = true;

                }
            }
            else
            {
                lifeBat -= 5;
                if (playerScript.venus == 1)
                {
                    isBurning = true;

                }
            }
        }
        if (collision.gameObject.tag == "BlackP")
        {
            anim.SetBool("Damaged", true);
            
            if (playerScript.mercury == 1)
            {
                lifeBat -= 10;
                if (playerScript.venus == 1)
                {
                    isBurning = true;

                }
            }
            else
            {
                lifeBat -= 5;
                if (playerScript.venus == 1)
                {
                    isBurning = true;

                }
            }
        }
        if (collision.gameObject.tag == "RedP")
        {

            // hace el doble de da�o contra tierra.
            // mas el 5 da�o del fuego
            //mas los 10 del mercurio
            anim.SetBool("Damaged", true);
            
            if (playerScript.mercury == 1)
            {
                lifeBat -= 25;
                if (playerScript.venus == 1)
                {
                    isBurning = true;

                }
            }
            else
            {
                lifeBat -= 15;
                if (playerScript.venus == 1)
                {
                    isBurning = true;

                }
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        anim.SetBool("Damaged", false);

    }
    public IEnumerator BatDead()
    {
        dmg.Play();
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);
        enemie.enemiesDead -= 1;
    }
    public IEnumerator VenusDPS()
    {

        // recibe un porcentaje de da�o de forma pasiva durante 3 segundos
        anim.SetBool("Damaged", true);
        rend.material.color = selectedColor;
        lifeBat -= 0.5f * Time.deltaTime;
        yield return new WaitForSeconds(3f);
        rend.material.color = originalColor;
        anim.SetBool("Damaged", false);
        isBurning = false;

        
        

    }
}
