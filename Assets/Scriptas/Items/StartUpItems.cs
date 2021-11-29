using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartUpItems : MonoBehaviour
{
    public GameObject[] startUp = new GameObject[16];
   

    public Transform spawn;
    



    public GameObject fireE;
    public GameObject waterE;
    public GameObject windE;
    public GameObject earthE;
   

    public GameObject instan;

    


    void Start()
    {
       

      
        int numero = Random.Range(0, 15);

        startUp[0] = fireE;
        startUp[1] = waterE;
        startUp[2] = windE;
        startUp[3] = earthE;

        startUp[4] = fireE;
        startUp[5] = waterE;
        startUp[6] = windE;
        startUp[7] = earthE;

        startUp[8] = fireE;
        startUp[9] = waterE;
        startUp[10] = windE;
        startUp[11] = earthE;

        startUp[12] = fireE;
        startUp[13] = waterE;
        startUp[14] = windE;
        startUp[15] = earthE;





        instan = startUp[numero];
        

        Instantiate(instan, spawn.position, Quaternion.identity);
       

       

    }

    // Update is called once per frame
    void Update()
    {

    }
}
