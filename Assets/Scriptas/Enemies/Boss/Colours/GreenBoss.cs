using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GreenBoss : MonoBehaviour
{
    public PlayerStats playerScript;
    public Rigidbody2D rb;
    public Animator anim;
    public float lifeBat;
    public bool isBurning = false;

    public GameObject gateSpawn;
    public GameObject gate;

    public AudioSource dmgAudio;

    private Renderer rend;
    private Color originalColor;
    public Color selectedColor = Color.red;
    void Start()
    {
        rend = GetComponentInChildren<Renderer>();
        
        originalColor = rend.material.color;

        gateSpawn = GameObject.Find("SpawnHole");
        lifeBat = 200;

        playerScript = FindObjectOfType<PlayerStats>();
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (lifeBat <= 0)
        {
            anim.SetTrigger("damage");
            rb.velocity = transform.right * 0;
            rb.velocity = transform.up * 0;
            StartCoroutine(BatDead());

        }

        if (isBurning == true)
        {
            StartCoroutine(VenusDPS());
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "GreenP")
        {
            anim.SetTrigger("damage");
            dmgAudio.Play();

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
        if (collision.tag == "BlueP")
        {
            anim.SetTrigger("damage");
            dmgAudio.Play();
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
        if (collision.tag == "PurpleP")
        {
            anim.SetTrigger("damage");
            dmgAudio.Play();

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
        if (collision.tag == "BlackP")
        {
            anim.SetTrigger("damage");
            dmgAudio.Play();
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
        if (collision.tag == "RedP")
        {
            // hace el doble de daño contra tierra.
            // mas el 5 daño del fuego
            //mas los 10 del mercurio
            anim.SetTrigger("damage");
            dmgAudio.Play();
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
        //el fuego hace +10 de daño

    }

    



    public IEnumerator BatDead()
    {
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);
        Instantiate(gate, gateSpawn.transform.position, Quaternion.Euler(35.5f, 0, 0));
    }

    public IEnumerator VenusDPS()
    {

        // recibe un porcentaje de daño de forma pasiva durante 3 segundos
        anim.SetTrigger("damage");
        rend.material.color = selectedColor;
        lifeBat -= 0.5f * Time.deltaTime;
        yield return new WaitForSeconds(3f);
        rend.material.color = originalColor;
        isBurning = false;


    }
}
