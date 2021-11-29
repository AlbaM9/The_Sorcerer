using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsYellRoom : MonoBehaviour
{
    public GameObject[] startUp = new GameObject[16];


    public Transform spawn;




    public GameObject mercury;
    public GameObject venus;
    public GameObject saturn;
    public GameObject uranus;



    public GameObject instan;


    public PlayerStats stats;

    void Start()
    {
        stats = FindObjectOfType<PlayerStats>();

        /*(if (stats.mercury == 1)
        {
            
        }
        if (stats.venus == 1)
        {

        }
        if (stats.saturn == 1)
        {

        }
        if (stats.uranus == 1)
        {

        }*/


        int numero = Random.Range(0, 15);

        startUp[0] = mercury;
        startUp[1] = venus;
        startUp[2] = saturn;
        startUp[3] = uranus;

        startUp[4] = mercury;
        startUp[5] = venus;
        startUp[6] = saturn;
        startUp[7] = uranus;

        startUp[8] = mercury;
        startUp[9] = venus;
        startUp[10] = saturn;
        startUp[11] = uranus;

        startUp[12] = mercury;
        startUp[13] = venus;
        startUp[14] = saturn;
        startUp[15] = uranus;


            if (stats.mercury == 1)
            {
                startUp[0] = null;
                startUp[4] = null;
                startUp[8] = null;
                startUp[12] = null;
            } 

            if (stats.venus == 1)
            {
                startUp[1] = null;
                startUp[5] = null;
                startUp[9] = null;
                startUp[13] = null;
            } 

            if (stats.saturn == 1)
            {
                startUp[2] = null;
                startUp[6] = null;
                startUp[10] = null;
                startUp[14] = null;
            } 

            if (stats.uranus == 1)
            {
                startUp[3] = null;
                startUp[7] = null;
                startUp[11] = null;
                startUp[15] = null;
            }
 
        instan = startUp[numero];
        while(instan==null)
        {
            numero = Random.Range(0, 15);
            instan = startUp[numero];
        }

        Instantiate(instan, spawn.position, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
