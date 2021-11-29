using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRoomDoors : MonoBehaviour
{
    

    public GameObject[] DoorsRight = new GameObject[12];
    public GameObject[] DoorsLeft = new GameObject[12];

    public Transform RIghtPos;
    public Transform LeftPos;

   
   
    public GameObject redRightDoor;
    public GameObject yelRightDoor;
    public GameObject browRightDoor;

    public GameObject  yelLeftDoor;
    public GameObject  redLeftDoor;
    public GameObject  browLeftDoor;

    public GameObject instan;
    public GameObject instanRight;

    public PlayerStats limiter;
    public int enemiesDead;
    public bool nowDoors = false;
    void Start()
    {
        limiter = FindObjectOfType<PlayerStats>();
        


       

        //si el limitador de objetos es mayor a 2 pueden aparecer todas las puertas

    }

    void Update()
    {
       
        if (enemiesDead <= 0)
        {
            nowDoors = true;
           
        }
        if (nowDoors == true)
        {
            DoorIns();
            enemiesDead = 6;
        }

    }
    void DoorIns() 
    {
        if (limiter.pULimiter < 1)
        {
            Debug.Log("Tienes 0");
            int numero = Random.Range(0, 11);
            DoorsLeft[0] = browLeftDoor;
            DoorsLeft[1] = browLeftDoor;
            DoorsLeft[2] = browLeftDoor;

            DoorsLeft[3] = yelLeftDoor;
            DoorsLeft[4] = browLeftDoor;
            DoorsLeft[5] = browLeftDoor;

            DoorsLeft[6] = browLeftDoor;
            DoorsLeft[7] = browLeftDoor;
            DoorsLeft[8] = browLeftDoor;

            DoorsLeft[9] = browLeftDoor;
            DoorsLeft[10] = browLeftDoor;
            DoorsLeft[11] = browLeftDoor;


            DoorsRight[2] = browRightDoor;
            DoorsRight[1] = browRightDoor;
            DoorsRight[0] = browRightDoor;

            DoorsRight[5] = browRightDoor;
            DoorsRight[4] = browRightDoor;
            DoorsRight[3] = browRightDoor;

            DoorsRight[7] = browRightDoor;
            DoorsRight[8] = browRightDoor;
            DoorsRight[6] = browRightDoor;

            DoorsRight[10] = yelRightDoor;
            DoorsRight[11] = browRightDoor;
            DoorsRight[9] = browRightDoor;

            instan = DoorsLeft[numero];
            instanRight = DoorsRight[numero];

            Instantiate(instan, LeftPos.position, Quaternion.identity);
            Instantiate(instanRight, RIghtPos.position, Quaternion.identity);

            Debug.Log(DoorsRight.Length);
            Debug.Log(DoorsLeft.Length);
            nowDoors = false;

        }

        if (limiter.pULimiter == 1)
        {
            Debug.Log("Tienes1");
            int numero2 = Random.Range(0, 11);
            DoorsLeft[0] = browLeftDoor;
            DoorsLeft[1] = yelLeftDoor;
            DoorsLeft[2] = browLeftDoor;

            DoorsLeft[3] = browLeftDoor;
            DoorsLeft[4] = browLeftDoor;
            DoorsLeft[5] = browLeftDoor;

            DoorsLeft[6] = browLeftDoor;
            DoorsLeft[7] = redLeftDoor;
            DoorsLeft[8] = browLeftDoor;

            DoorsLeft[9] = browLeftDoor;
            DoorsLeft[10] = browLeftDoor;
            DoorsLeft[11] = yelLeftDoor;


            DoorsRight[2] = browRightDoor;
            DoorsRight[1] = redRightDoor;
            DoorsRight[0] = browRightDoor;

            DoorsRight[5] = browRightDoor;
            DoorsRight[4] = browRightDoor;
            DoorsRight[3] = browRightDoor;

            DoorsRight[7] = browRightDoor;
            DoorsRight[8] = browRightDoor;
            DoorsRight[6] = browRightDoor;

            DoorsRight[10] = browRightDoor;
            DoorsRight[11] =browRightDoor;
            DoorsRight[9] = browRightDoor;

            instan = DoorsLeft[numero2];
            instanRight = DoorsRight[numero2];

            Instantiate(instan, LeftPos.position, Quaternion.identity);
            Instantiate(instanRight, RIghtPos.position, Quaternion.identity);

            Debug.Log(DoorsRight.Length);
            Debug.Log(DoorsLeft.Length);
            nowDoors = false;




        }
        if (limiter.pULimiter == 2)
        {
            Debug.Log("Tienes2");
            int numero3 = Random.Range(0, 11);
            DoorsLeft[0] = browLeftDoor;
            DoorsLeft[1] = redLeftDoor;
            DoorsLeft[2] = browLeftDoor;

            DoorsLeft[3] = browLeftDoor;
            DoorsLeft[4] = redLeftDoor;
            DoorsLeft[5] = browLeftDoor;

            DoorsLeft[6] = browLeftDoor;
            DoorsLeft[7] = browLeftDoor;
            DoorsLeft[8] = browLeftDoor;

            DoorsLeft[9] = browLeftDoor;
            DoorsLeft[10] = redLeftDoor;
            DoorsLeft[11] = browLeftDoor;


            DoorsRight[2] = browRightDoor;
            DoorsRight[1] = browRightDoor;
            DoorsRight[0] = redRightDoor;

            DoorsRight[5] = redRightDoor;
            DoorsRight[4] = browRightDoor;
            DoorsRight[3] = browRightDoor;

            DoorsRight[7] = browRightDoor;
            DoorsRight[8] = redRightDoor;
            DoorsRight[6] = browRightDoor;

            DoorsRight[10] = browRightDoor;
            DoorsRight[11] = browRightDoor;
            DoorsRight[9] = browRightDoor;

            instan = DoorsLeft[numero3];
            instanRight = DoorsRight[numero3];
            //if enemies muertos instanciar las puertas:


            Instantiate(instan, LeftPos.position, Quaternion.identity);
            Instantiate(instanRight, RIghtPos.position, Quaternion.identity);

            Debug.Log(DoorsRight.Length);
            Debug.Log(DoorsLeft.Length);
            nowDoors = false;



        }



    }
}
