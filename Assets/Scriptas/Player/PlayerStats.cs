using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public Animator anim;
    [Header("Health Settings")]
    
    public float playerHealth;
    public float dmgsFires;

    [Header("Initial Elements")]
    public int fireElement;
    public int waterElement;
    public int earthElement;
    public int airElement;

    [Header("PowerUps")]

    public int mercury;
    public int venus;
    public int saturn;
    public int uranus;

    [Header("Canvas")]

    public GameObject interlude2;
    public GameObject endGame;
    public GameObject deathMenu;
    public GameObject status;
    

    [Header("PowerUpLimiter")]

    public int pULimiter ;
    public int pu1, pu2, pu3, pu4;

    [Header("Scripts")]
    public PlayerProjectile projScript;
    public PlayerController2D playerSpeed;

    [Header("UIItems")]
    public Image hStatus;

    public Image WatImg;
    public Image FireImg;
    public Image AirImg;
    public Image EarthImg;

    public Image MercImg;
    public Image VenImg;
    public Image UraImg;
    public Image SatImg;

    [Header("Audio")]
    public AudioSource endGameSound;
    public AudioSource mainSoundBoss;


    void Start()
    {
        interlude2 = GameObject.Find("Interlude2");
        endGame = GameObject.Find("FinishMenu");
        deathMenu = GameObject.Find("DeathMenu");
        status = GameObject.Find("Status");

        interlude2.SetActive(false);
        endGame.SetActive(false);
        deathMenu.SetActive(false);
        status.SetActive(true);

        hStatus.enabled = true;

        WatImg.enabled = false;
        FireImg.enabled = false;
        AirImg.enabled = false;
        EarthImg.enabled = false;

        MercImg.enabled = false;
        VenImg.enabled = false;
        UraImg.enabled = false;
        SatImg.enabled = false;




        anim = GetComponent<Animator>();
        projScript = FindObjectOfType<PlayerProjectile>();
        playerSpeed = FindObjectOfType<PlayerController2D>();

        playerHealth = 100f;
        
        fireElement = 0;
        waterElement = 0;
        airElement = 0;
        earthElement = 0;

        mercury = 0;
        venus = 0;
        saturn = 0;
        uranus = 0;

      

       

    }

    // Update is called once per frame
    void Update()
    {
        hStatus.fillAmount = playerHealth / 100f;
        pULimiter = (pu1 + pu2 + pu3+ pu4);
        if (fireElement ==1) //aumenta el daño base
        {

            FireImg.enabled = true;
        }
        if (airElement == 1) //aumenta la velocidad del player
        {
            AirImg.enabled = true;
            playerSpeed.speed = 13;
        }
        if (earthElement == 1)
        {
            EarthImg.enabled = true;
            projScript.proEarth .transform.localScale = new Vector3(0.8f, 0.8f, 0);
            projScript.fireDelay = 0.8f;
        }
        else
        {
            projScript.projectile.transform.localScale = new Vector3(0.4f, 0.4f, 0);
        }
        if (waterElement == 1) 
        {
            WatImg.enabled = true;
            //projScript.fireDelay = 0.2f;
        }

        if (uranus == 1)
        {
            UraImg.enabled = true;
            projScript.fireDelay = 0.25f;

            if (earthElement == 1)
            {
                projScript.fireDelay = 0.4f;
            }
        }
        if (playerHealth <= 0)
        {
            anim.SetBool("Death", true);
            StartCoroutine(Death());
            PlayerPrefs.DeleteAll();
            PlayerPrefs.SetFloat("health", playerHealth);
        }
        if (mercury == 1)
        {
            MercImg.enabled = true;
        }
        if (venus == 1)
        {
            VenImg.enabled = true;
        }
        if (saturn == 1)
        {
            SatImg.enabled = true;
        }
    }
     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Fire")
        {
            Debug.Log("Entra");
            fireElement = 1;
            Destroy(GameObject.FindWithTag("Fire"));
           
        }
        if (collision.gameObject.tag == "Air")
        {
            Debug.Log("Entra");
            airElement = 1;
            Destroy(GameObject.FindWithTag("Air"));
           
        }
        if (collision.gameObject.tag == "Earth")
        {
            Debug.Log("Entra");
            earthElement = 1;
            Destroy(GameObject.FindWithTag("Earth"));
            
        }
        if (collision.gameObject.tag == "Water")
        {
            Debug.Log("Entra");
            waterElement = 1;
            Destroy(GameObject.FindWithTag("Water"));
            
        }
        if (collision.gameObject.tag == "Mercury")
        {
            Debug.Log("Entra");
            mercury = 1;
            Destroy(GameObject.FindWithTag("Mercury"));
            pu1 = 1;
            
        }

        if (collision.gameObject.tag == "Uranus")
        {
            Debug.Log("Entra");
            uranus = 1;
            Destroy(GameObject.FindWithTag("Uranus"));
            pu2 = 1;
            
        }

        if (collision.gameObject.tag == "Saturn")
        {
            Debug.Log("Entra");
            saturn = 1;
            Destroy(GameObject.FindWithTag("Saturn"));
            pu3 = 1;
            
        }
        if (collision.gameObject.tag == "Venus")
        {
            Debug.Log("Entra");
            venus = 1;
            Destroy(GameObject.FindWithTag("Venus"));
            pu4 = 1;
            
        }

        if (collision.gameObject.tag == "laser")
        {
            anim.SetBool("Hurt", true);
            playerHealth -= 10;
        }

        if (collision.tag == "EarthBossP")
        {
            anim.SetBool("Hurt", true);
            if (airElement == 1)
            {
                playerHealth -= 20;
            }
            else
            {
                playerHealth -= 10;
            }

        }
        if (collision.tag == "WaterBossP")
        {
            anim.SetBool("Hurt", true);
            if (fireElement == 1)
            {
                playerHealth -= 20;
            }
            else
            {
                playerHealth -= 10;
            }

        }
        if (collision.tag == "AirBossP")
        {
            anim.SetBool("Hurt", true);

            if (waterElement == 1)
            {
                playerHealth -= 20;
            }
            else
            {
                playerHealth -= 10;
            }
        }
      
        if (collision.tag == "FireBossP")
        {
            anim.SetBool("Hurt", true);
            if (earthElement == 1)
            {
                playerHealth -= 20;
            }
            else
            {
                playerHealth -= 10;
            }
        }

        if (collision.tag == "ExitGate")
        {
      
            StartCoroutine(Inerlude2());

           //load finish interlude scene.
        }
        //el fuego hace +10 de daño

       

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if (collision.tag == "FireBlue")
        {
            anim.SetBool("Hurt", true);
            if (fireElement == 1)
            {
                dmgsFires = 1;
                playerHealth -= dmgsFires * Time.deltaTime;
            }
            else
            {
                dmgsFires = 0.5f;
                playerHealth -= dmgsFires * Time.deltaTime;
            }

        }
        if (collision.tag == "FireGreen")
        {
            anim.SetBool("Hurt", true);
            if (airElement == 1)
            {
                dmgsFires = 1;
                playerHealth -= dmgsFires * Time.deltaTime;
            }
            else
            {
                dmgsFires = 0.5f;
                playerHealth -= dmgsFires * Time.deltaTime;
            }
        }

        if (collision.tag == "FireRed")
        {
            anim.SetBool("Hurt", true);
            if (earthElement == 1)
            {
                dmgsFires = 1;
                playerHealth -= dmgsFires * Time.deltaTime;
            }
            else
            {
                dmgsFires = 0.5f;
                playerHealth -= dmgsFires * Time.deltaTime;
            }
        }
        if (collision.tag == "FirePurple")
        {
            anim.SetBool("Hurt", true);
            if (waterElement == 1)
            {
                dmgsFires = 1;
                playerHealth -= dmgsFires * Time.deltaTime;
            }
            else
            {
                dmgsFires = 0.5f;
                playerHealth -= dmgsFires * Time.deltaTime;
            }
        }




    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        anim.SetBool("Hurt", false);
        playerHealth -= 0* Time.deltaTime;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bats")
        {

            anim.SetBool("Hurt", true);

        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        anim.SetBool("Hurt", false);
    }
    IEnumerator Death() 
    {
        yield return new WaitForSeconds(1f);
        Time.timeScale = 0;
        deathMenu.SetActive(true);
    }

    public IEnumerator BossFires()
    {

        // recibe un porcentaje de daño de forma pasiva durante el tiempo que estes dentro


       
        yield return new WaitForSeconds(3f);
        anim.SetBool("Hurt", false);
       

    }
    public IEnumerator Inerlude2()
    {
        mainSoundBoss.Stop();
        endGameSound.Play();
        interlude2.SetActive(true);
        Debug.Log("Final");
        yield return new WaitForSeconds(3);
        interlude2.SetActive(false);
        Time.timeScale = 0;
        endGame.SetActive(true);
    }
}
