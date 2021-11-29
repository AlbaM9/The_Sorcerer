using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InBallFire : MonoBehaviour
{
   
    public Rigidbody2D rb;
   
    public float thrust = 1f;

   

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = new Vector2((float)Random.Range(-100, 100), (float)Random.Range(-100, 100));
        float force = 1f;
        rb.AddForce(direction * force);
        Destroy(gameObject, 3);

    }
}
