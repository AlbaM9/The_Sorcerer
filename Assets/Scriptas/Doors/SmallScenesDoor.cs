using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallScenesDoor : MonoBehaviour
{
    
    public GameObject browLeftDoor;
    public GameObject browRightDoor;

    public Transform RIghtPos;
    public Transform LeftPos;


    void Start()
    {
        Instantiate(browLeftDoor, LeftPos.position, Quaternion.identity);
        Instantiate(browRightDoor, RIghtPos.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
