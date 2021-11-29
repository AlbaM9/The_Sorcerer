using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneBehaveur : MonoBehaviour
{
   // public Rigidbody2D rb;

    public float force = 1f;
    private Transform player;

    private Vector2 target;
    private Vector2 dir;
    

    void Start()
    {
        player = GameObject.Find("Player").transform;
        //rb = GetComponent<Rigidbody2D>();
        target = new Vector2(player.position.x, player.position.y);
        dir = gameObject.transform.position;
        //si colocas estas dos variables en el update el hueso sigue al player hasta que desaparece;
    }

    // Update is called once per frame
    void Update()
    {
       
        //Vector2 direction = new Vector2((float)transform.right.x, 0);
        float step = force * Time.deltaTime;
       
        transform.position = Vector2.MoveTowards(transform.position, target, step);

        //rb.velocity = direction  * force;
        // rb.AddForce (direction * force);
        Destroy(gameObject, 3);

       
    }
}
