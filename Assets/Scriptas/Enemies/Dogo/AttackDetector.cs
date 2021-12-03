using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackDetector : MonoBehaviour
{
    public DogosBehaveur dogbeh;
    void Start()
    {
        dogbeh = FindObjectOfType<DogosBehaveur>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D Collider2D)
    {
        if (Collider2D.tag == "RedP")
        {
           dogbeh. beingDamaged = true;
        }
        if (Collider2D.tag == "BlueP")
        {
            dogbeh.beingDamaged = true;

        }
        if (Collider2D.tag == "PurpleP")
        {
            dogbeh.beingDamaged = true;
        }
        if (Collider2D.tag == "GreenP")
        {
            dogbeh.beingDamaged = true;
        }
        if (Collider2D.tag == "BlackP")
        {
            dogbeh.beingDamaged = true;
        }

    }

    private void OnTriggerExit2D(Collider2D Collider2D)
    {
        if (Collider2D.tag == "RedP")
        {
            dogbeh.beingDamaged = false;
        }
        if (Collider2D.tag == "BlueP")
        {
            dogbeh.beingDamaged = false;
        }
        if (Collider2D.tag == "PurpleP")
        {
            dogbeh.beingDamaged = false;
        }
        if (Collider2D.tag == "GreenP")
        {
            dogbeh.beingDamaged = false;
        }
        if (Collider2D.tag == "BlackP")
        {
            dogbeh.beingDamaged = false;
        }

    }
}
