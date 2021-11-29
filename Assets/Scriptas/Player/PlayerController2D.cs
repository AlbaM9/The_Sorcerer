using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    public float speed;
    float velX, velY,velV;
    public Rigidbody2D rb;

    public PlayerProjectile projectile;
  

    Animator anim;



    void Start()
    {
        speed = 8;
        projectile = FindObjectOfType<PlayerProjectile>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }


    void Update()
    {
        if (projectile.freezeFlip == false)
        {

            Flip();

        }
        else if(projectile.freezeFlip == true) 
        {
        
        }


    }

    private void FixedUpdate()

    {
        Movement();

    }

   
    public void Movement()
    {
        
        velX = Input.GetAxisRaw("Horizontal");
        velY = Input.GetAxisRaw("Vertical");//rb.velocity.y;


        rb.velocity = new Vector2(velX * speed, velY  *speed);
       

        if ((rb.velocity.x != 0) || (rb.velocity.y != 0))
        {

            anim.SetBool("Walk", true);

        }
        else
        {
            anim.SetBool("Walk", false);

        }

       

        
        
       
         
    }
    public void Flip()
    {

        if (velX /* rb.velocity.x */> 0) 
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (velX /* rb.velocity.x */< 0)  //voltea al player
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }


        
    }

}

