using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StatusLaserFlea
{
    IDLE,
    WALK,
    ATTACK_1,
   


}
public class LaserFleaMovement : MonoBehaviour
{
    public PlayerStats fire;
    public ItemRoomDoors enemie;

    public Transform laserSpawn;
    public GameObject laser;
    public Animator anim;
    public Rigidbody2D rb;

    public StatusLaserFlea LFStatus;

    public float speed;
    public float fleaLife;

    public float statCh;
    public Vector2 direction;
    public bool isBurning = false;

    public AudioSource hurted;

    private Renderer rend;
    private Color originalColor;
    public Color selectedColor = Color.red;
    void Start()
    {
        rend = GetComponent<Renderer>();
        originalColor = rend.material.color;

        enemie = FindObjectOfType<ItemRoomDoors>();
        fire = FindObjectOfType<PlayerStats>();
        
        fleaLife = 60f;
        LFStatus = StatusLaserFlea.IDLE;
        anim = GetComponent<Animator>();

        StartCoroutine(Statuses());
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (fleaLife <= 0)
        {
            anim.SetBool("Death", true);
            rb.velocity = direction * 0;
            StartCoroutine(BatDead());
        }
        direction = (transform.right + transform.up);

        if (isBurning == true)
        {
            StartCoroutine(VenusDPS());
        }
    }

    IEnumerator Statuses()
    {
        var randomAttack = Random.Range(1, 5);

        yield return new WaitForSeconds(statCh);

        switch (randomAttack)
        {
            case 1:
                LFStatus = StatusLaserFlea.IDLE;
                break;
            case 2:
                LFStatus = StatusLaserFlea.WALK;
                break;
            case 3:
                LFStatus = StatusLaserFlea.ATTACK_1;
                break;
           

        }
        StatusChanger();
    }
    
    public void StatusChanger()
    {
        switch (LFStatus)
        {
            case StatusLaserFlea.IDLE:
                anim.SetBool("Walk", false);
                speed = 0;
                StartCoroutine(Statuses());
                break;


            case StatusLaserFlea.WALK:
                speed = 5;
                anim.SetBool("Walk", true);
                
                rb.velocity = direction * -speed;
                
                StartCoroutine(Statuses());
                break;


            case StatusLaserFlea.ATTACK_1:

                anim.SetBool("Attack", true);
                anim.SetBool("Walk", false);
                speed = 0;
                Instantiate(laser, laserSpawn.position, Quaternion.identity);

                StartCoroutine(Statuses());
                break;
            

        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Walls")
        {
            Debug.Log("MyTag");
            
            rb.velocity = direction * speed;
        }
      
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

      

        if (collision.tag == "RedP")
        {
            anim.SetBool("Hurt", true);
            
            fleaLife -= 10;

            
                if (fire.venus == 1)
                {
                    isBurning = true;

                }
           

        }
        if (collision.tag == "BlueP")
        {
            anim.SetBool("Hurt", true);
            
            fleaLife -= 5;

            if (fire.venus == 1)
            {
                isBurning = true;

            }


        }
        if (collision.tag == "PurpleP")
        {
            anim.SetBool("Hurt", true);
           
            fleaLife -= 5;

            if (fire.venus == 1)
            {
                isBurning = true;

            }


        }
        if (collision.tag == "GreenP")
        {
            anim.SetBool("Hurt", true);
            
            fleaLife -= 5;

            if (fire.venus == 1)
            {
                isBurning = true;

            }


        }
        if (collision.tag == "BlackP")
        {
            anim.SetBool("Hurt", true);
           

            fleaLife -= 5;

            if (fire.venus == 1)
            {
                isBurning = true;

            }

          
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        
        anim.SetBool("Hurt", false);
    }


    public IEnumerator BatDead()
    {
        hurted.Play();
        yield return new WaitForSeconds(2);
        Destroy(this.gameObject);
        enemie.enemiesDead -= 1;
    }
    public IEnumerator VenusDPS()
    {
        // recibe un porcentaje de daño de forma pasiva durante 3 segundos. Doble de daño en torretas.

        anim.SetBool("Hurt", true);
        rend.material.color = selectedColor;
        fleaLife -= 1f * Time.deltaTime;
        yield return new WaitForSeconds(3f);
        rend.material.color = originalColor;
        anim.SetBool("Hurt", false);
        

        isBurning = false;
        
    }
   
   
}
