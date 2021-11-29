using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossRandomInst : MonoBehaviour
{
    private BlueBoss blue;
    private GreenBoss green;
    private RedBoss red;
    private PurpleBoss purple;

   
    public Image ststus;
    public Text name;

    public GameObject[] bossSpawn = new GameObject[16];


    public Transform spawnBoss;


    public GameObject earthBoss;
    public GameObject waterBoss;
    public GameObject fireBoss;
    public GameObject airBoss;


    private GameObject instan;

    public int data;
    

    void Start()
    {
        

         int numero = Random.Range(0, 15);


        bossSpawn[0] = earthBoss;
        bossSpawn[1] = waterBoss;
        bossSpawn[2] = fireBoss;
        bossSpawn[3] = airBoss;

        bossSpawn[4] = earthBoss;
        bossSpawn[5] = waterBoss;
        bossSpawn[6] = fireBoss;
        bossSpawn[7] = airBoss;

        bossSpawn[8] = earthBoss;
        bossSpawn[9] = waterBoss;
        bossSpawn[10] = fireBoss;
        bossSpawn[11] = airBoss;

        bossSpawn[12] = earthBoss;
        bossSpawn[13] = waterBoss;
        bossSpawn[14] = fireBoss;
        bossSpawn[15] = airBoss;

        
       


        instan = bossSpawn[numero];


        Instantiate(instan, spawnBoss.position, Quaternion.identity);
        ststus.enabled = true;
        name.enabled = true;

        if (numero == 0 || numero == 4 || numero == 8 || numero == 12)
        {          
            green = FindObjectOfType<GreenBoss>();
            data = 1;
        }
        if (numero == 1|| numero == 5 || numero == 9 || numero == 13)
        {
            blue = FindObjectOfType<BlueBoss>();
            data = 2;
        }
        if (numero == 2 || numero == 6 || numero == 10 || numero == 14)
        {
            red = FindObjectOfType<RedBoss>();
            data = 3;
        }
        if (numero == 3 || numero == 7 || numero == 11 || numero == 15)
        {
            purple = FindObjectOfType<PurpleBoss>();
            data = 4;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (data == 3)
        {
            ststus.fillAmount = red.lifeBat / 200f;

            if (red.lifeBat <= 0)
            {
                name.enabled = false;
            }
        }
      
        if (data == 2)
        {
            ststus.fillAmount = blue.lifeBat / 200f;

            if (blue.lifeBat <= 0)
            {
                name.enabled = false;
            }

        }
        if (data == 4)
        {
            ststus.fillAmount = purple.lifeBat / 200f;

            if (purple.lifeBat <= 0)
            {
                name.enabled = false;
            }
        }
        if (data == 1)
        {
            ststus.fillAmount = green.lifeBat / 200f;

            if (green.lifeBat <= 0)
            {
                name.enabled = false;
            }
        }


       

      

      
        


    }
}
