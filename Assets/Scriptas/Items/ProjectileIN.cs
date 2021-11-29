using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileIN : MonoBehaviour
{
    public PlayerStats balls;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(this.gameObject, 0.5f);
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Walls")
        {
            Destroy(this.gameObject);
        }
    }

    public IEnumerator DamageTimer()
    {
        yield return  new WaitForSeconds(1f);

    }
}
