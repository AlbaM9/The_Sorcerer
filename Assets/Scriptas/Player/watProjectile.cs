using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class watProjectile : MonoBehaviour
{
    public Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = new Vector2(0, (float)Random.Range(-100, 100));
        float force = 3f;
        rb.AddForce(direction * force);
        //(float)Random.Range(0, 0)
    }
}
