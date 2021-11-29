using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    public GameObject projectile;
    public GameObject proFire;
    public GameObject proEarth;
    public GameObject proWind;
    public GameObject proWater;

    private GameObject bullet;
    private GameObject bullet2;
    private GameObject bullet3;

    public Transform shootPoint;

    public AudioSource balls;
    Animator anim;

   //
    public float speed;
    private float lastFire;
    public float fireDelay;

    public PlayerController2D player;
    public PlayerStats projDmg;
    

    public bool freezeFlip;

    void Start()
    {
       
        anim = GetComponent<Animator>();
        player = FindObjectOfType<PlayerController2D>();
        projDmg = FindObjectOfType<PlayerStats>();
     
    }


    void Update()
    {
        float shootHor = Input.GetAxis("HorizontalShoot");
        float shootVert = Input.GetAxis("VerticalShoot");

      
       if (Input.GetAxis("HorizontalShoot") != 0 || Input.GetAxis("VerticalShoot") !=0)
        {
            
            freezeFlip = true;
        } else
        {
           
            freezeFlip = false;
        }

        if ((shootHor !=0 || shootVert !=0) && Time.time > lastFire + fireDelay)
        {
            balls.Play();
            Shoot(shootHor,shootVert);
            lastFire = Time.time;
            
        }
       

       

    }
            
        
    void Shoot(float x, float y)
    {
        
        if (projDmg.saturn == 0)
        {
            if (projDmg.fireElement == 1)
            {
                bullet = Instantiate(proFire, shootPoint.position, Quaternion.identity) as GameObject;
                bullet.GetComponent<Rigidbody2D>().velocity = new Vector2((x < 0) ? Mathf.Floor(x) * speed : Mathf.Ceil(x) * speed,
                                                                          (y < 0) ? Mathf.Floor(y) * speed : Mathf.Ceil(y) * speed);
            }
            else if (projDmg.airElement == 1)
            {
                bullet = Instantiate(proWind, shootPoint.position, Quaternion.identity) as GameObject;
                bullet.GetComponent<Rigidbody2D>().velocity = new Vector2((x < 0) ? Mathf.Floor(x) * speed : Mathf.Ceil(x) * speed,
                                                                          (y < 0) ? Mathf.Floor(y) * speed : Mathf.Ceil(y) * speed);
            }
            else if (projDmg.earthElement == 1)
            {
                bullet = Instantiate(proEarth, shootPoint.position, Quaternion.identity) as GameObject;
                bullet.GetComponent<Rigidbody2D>().velocity = new Vector2((x < 0) ? Mathf.Floor(x) * speed : Mathf.Ceil(x) * speed,
                                                                          (y < 0) ? Mathf.Floor(y) * speed : Mathf.Ceil(y) * speed);
            }
            else if (projDmg.waterElement == 1)
            {
                bullet = Instantiate(proWater, shootPoint.position, Quaternion.identity) as GameObject;
                bullet.GetComponent<Rigidbody2D>().velocity = new Vector2((x < 0) ? Mathf.Floor(x) * speed : Mathf.Ceil(x) * speed,
                                                                          (y < 0) ? Mathf.Floor(y) * speed : Mathf.Ceil(y) * speed);
            }
            else
            {
                bullet = Instantiate(projectile, shootPoint.position, Quaternion.identity) as GameObject;
                bullet.GetComponent<Rigidbody2D>().velocity = new Vector2((x < 0) ? Mathf.Floor(x) * speed : Mathf.Ceil(x) * speed,
                                                                          (y < 0) ? Mathf.Floor(y) * speed : Mathf.Ceil(y) * speed);
            }
        } else
        {
            if (projDmg.fireElement == 1)
            {
                bullet = Instantiate(proFire, shootPoint.position, Quaternion.identity) as GameObject;
                bullet2 = Instantiate(proFire, shootPoint.position, Quaternion.identity) as GameObject;
                bullet3 = Instantiate(proFire, shootPoint.position, Quaternion.identity) as GameObject;

                bullet.GetComponent<Rigidbody2D>().velocity = new Vector2((x < 0) ? Mathf.Floor(x) * speed : Mathf.Ceil(x) * speed,
                                                                          (y < 0) ? Mathf.Floor(y) * speed : Mathf.Ceil(y) * speed);
                bullet2.GetComponent<Rigidbody2D>().velocity = new Vector2((x < 0) ? Mathf.Floor(x) * speed : Mathf.Ceil(x) * speed,
                                                                            (y < 0) ? Mathf.Floor(y) * speed - 10 : Mathf.Ceil(y) * speed - 10);
                bullet3.GetComponent<Rigidbody2D>().velocity = new Vector2((x < 0) ? Mathf.Floor(x) * speed : Mathf.Ceil(x) * speed,
                                                                            (y < 0) ? Mathf.Floor(y) * speed + 10 : Mathf.Ceil(y) * speed + 10);
            }
            else if (projDmg.airElement == 1)
            {
                bullet = Instantiate(proWind, shootPoint.position, Quaternion.identity) as GameObject;
                bullet2 = Instantiate(proWind, shootPoint.position, Quaternion.identity) as GameObject;
                bullet3 = Instantiate(proWind, shootPoint.position, Quaternion.identity) as GameObject;

                bullet.GetComponent<Rigidbody2D>().velocity = new Vector2((x < 0) ? Mathf.Floor(x) * speed : Mathf.Ceil(x) * speed,
                                                                          (y < 0) ? Mathf.Floor(y) * speed : Mathf.Ceil(y) * speed);
                bullet2.GetComponent<Rigidbody2D>().velocity = new Vector2((x < 0) ? Mathf.Floor(x) * speed : Mathf.Ceil(x) * speed,
                                                                            (y < 0) ? Mathf.Floor(y) * speed - 10 : Mathf.Ceil(y) * speed - 10);
                bullet3.GetComponent<Rigidbody2D>().velocity = new Vector2((x < 0) ? Mathf.Floor(x) * speed : Mathf.Ceil(x) * speed,
                                                                            (y < 0) ? Mathf.Floor(y) * speed + 10 : Mathf.Ceil(y) * speed + 10);
            }
            else if (projDmg.earthElement == 1)
            {
                bullet = Instantiate(proEarth, shootPoint.position, Quaternion.identity) as GameObject;
                bullet2 = Instantiate(proEarth, shootPoint.position, Quaternion.identity) as GameObject;
                bullet3 = Instantiate(proEarth, shootPoint.position, Quaternion.identity) as GameObject;

                bullet.GetComponent<Rigidbody2D>().velocity = new Vector2((x < 0) ? Mathf.Floor(x) * speed : Mathf.Ceil(x) * speed,
                                                                          (y < 0) ? Mathf.Floor(y) * speed : Mathf.Ceil(y) * speed);
                bullet2.GetComponent<Rigidbody2D>().velocity = new Vector2((x < 0) ? Mathf.Floor(x) * speed : Mathf.Ceil(x) * speed,
                                                                            (y < 0) ? Mathf.Floor(y) * speed - 10 : Mathf.Ceil(y) * speed - 10);
                bullet3.GetComponent<Rigidbody2D>().velocity = new Vector2((x < 0) ? Mathf.Floor(x) * speed : Mathf.Ceil(x) * speed,
                                                                            (y < 0) ? Mathf.Floor(y) * speed + 10 : Mathf.Ceil(y) * speed + 10);
            }
            else if (projDmg.waterElement == 1)
            {
                bullet = Instantiate(proWater, shootPoint.position, Quaternion.identity) as GameObject;
                bullet2 = Instantiate(proWater, shootPoint.position, Quaternion.identity) as GameObject;
                bullet3 = Instantiate(proWater, shootPoint.position, Quaternion.identity) as GameObject;

                bullet.GetComponent<Rigidbody2D>().velocity = new Vector2((x < 0) ? Mathf.Floor(x) * speed : Mathf.Ceil(x) * speed,
                                                                          (y < 0) ? Mathf.Floor(y) * speed : Mathf.Ceil(y) * speed);
                bullet2.GetComponent<Rigidbody2D>().velocity = new Vector2((x < 0) ? Mathf.Floor(x) * speed : Mathf.Ceil(x) * speed,
                                                                            (y < 0) ? Mathf.Floor(y) * speed - 10 : Mathf.Ceil(y) * speed - 10);
                bullet3.GetComponent<Rigidbody2D>().velocity = new Vector2((x < 0) ? Mathf.Floor(x) * speed : Mathf.Ceil(x) * speed,
                                                                            (y < 0) ? Mathf.Floor(y) * speed + 10 : Mathf.Ceil(y) * speed + 10);
            }
            else
            {
                bullet = Instantiate(projectile, shootPoint.position, Quaternion.identity) as GameObject;
                bullet2 = Instantiate(projectile, shootPoint.position, Quaternion.identity) as GameObject;
                bullet3 = Instantiate(projectile, shootPoint.position, Quaternion.identity) as GameObject;

                bullet.GetComponent<Rigidbody2D>().velocity = new Vector2((x < 0) ? Mathf.Floor(x) * speed : Mathf.Ceil(x) * speed,
                                                                          (y < 0) ? Mathf.Floor(y) * speed : Mathf.Ceil(y) * speed);
                bullet2.GetComponent<Rigidbody2D>().velocity = new Vector2((x < 0) ? Mathf.Floor(x) * speed : Mathf.Ceil(x) * speed,
                                                                            (y < 0) ? Mathf.Floor(y) * speed : Mathf.Ceil(y) * speed - 10);
                bullet3.GetComponent<Rigidbody2D>().velocity = new Vector2((x < 0) ? Mathf.Floor(x) * speed : Mathf.Ceil(x) * speed,
                                                                            (y < 0) ? Mathf.Floor(y) * speed : Mathf.Ceil(y) * speed + 10);

                
            }
        }
            
       


       
        
       
    }
    

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            //enemiesHealth - projDmg.projDamage;
        }
    }
}
