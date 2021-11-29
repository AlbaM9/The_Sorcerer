using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatDvDEnemy : MonoBehaviour
{
    public Transform target;
    public int rutina;
    public float cronometro;
    public Animator anim;
    public Quaternion angulo;
    public float grado;

    public float speed;
    float velX, velY, velV;
    public Rigidbody2D rb;


    public PlayerStats playerHealth;
    void Start()
    {
        playerHealth = FindObjectOfType<PlayerStats>();
        rb = GetComponent<Rigidbody2D>();
        anim.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        EnemyMovement();
        //velX = rb.velocity.x;
       // velY = rb.velocity.y;
       
       
    }


   public void EnemyMovement() 
   {
       
          cronometro += 1 * Time.deltaTime;
          if (cronometro >= 1.5f)
          {
              rutina = Random.Range(0, 4);
              cronometro = 0;

          }
       
        switch (rutina) 
            {

               
                case 0:
                rb.velocity = transform.right * speed;
                   // transform.Translate(Vector2.right * speed * Time.deltaTime);
                    transform.localScale = new Vector2(-2, 2);
                   
                    break;

                case 1:
                rb.velocity = transform.right * - speed;
                //transform.Translate(Vector2.left * speed * Time.deltaTime);
                transform.localScale = new Vector2(2, 2);

                    
                    break;
                case 2:
                rb.velocity = transform.up * speed;
                //transform.Translate(Vector2.up * speed * Time.deltaTime);
                transform.localScale = new Vector2(2, 2);
                  
                    break;
                case 3:
                rb.velocity = transform.up * - speed;
                //transform.Translate(Vector2.down * speed * Time.deltaTime);


                break;


            }


   }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            
            Debug.Log("detection");
           
            anim.SetBool("Attack", true);
           
        }
        else
        {
            anim.SetBool("Attack", false);
            anim.SetBool("Run", true);
        }
        


    }
    


}
   
