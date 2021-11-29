using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum FireBossStatus
{   TELEPORT,
    IDLE,
    ATTACK_1,
    ATTACK_2,
    DEATH


}
public class FireBossScript : MonoBehaviour
{
    public GameObject spawnsFireonPlayer;
    public GameObject fireAttack;

    public Transform player;
   
    
    public Transform ballsPOSU;
    public Transform ballsPOSD;
    public Transform ballsPOSR;
    public Transform ballsPOSL;

    public Transform ballsPOSL2;
    public Transform ballsPOSR2;
    public Transform ballsPOSUD;
    public Transform ballsPOSDR;

    Animator anim;


   

    public FireBossStatus fBStatus;

    

    public float statCh;
    void Start()
    {
       
        fBStatus = FireBossStatus.IDLE;
        anim = GetComponent<Animator>();
       
        StartCoroutine(Statuses());
        player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        


    }
    IEnumerator Statuses() 
    {
        var randomAttack = Random.Range(1, 5);

        yield return new WaitForSeconds(statCh);

        switch (randomAttack)
        {
            case 1:
                fBStatus = FireBossStatus.IDLE;
                break;
            case 2:
                fBStatus = FireBossStatus.TELEPORT;
                break;
            case 3:
                fBStatus = FireBossStatus.ATTACK_1;
                break;
            case 4:
                fBStatus = FireBossStatus.ATTACK_2;
                break;
           
        }
        StatusChanger();
    }
    IEnumerator FireSpawn()
    {

        Instantiate(spawnsFireonPlayer, player.position, Quaternion.identity);
        yield return new WaitForSeconds(1);
       //Qu haga daño al segundo de haber spawneado.

    }
    public void StatusChanger() 
    {
        switch (fBStatus)
        {
            case FireBossStatus.TELEPORT:
                
                transform.position = new Vector2((float)Random.Range(-10, 10), (float)Random.Range(-10, 10));
                StartCoroutine(Statuses());
                break;
            case FireBossStatus.IDLE:
                StartCoroutine(Statuses());
                break;
            case FireBossStatus.ATTACK_1:
                anim.SetTrigger("attack");
                StartCoroutine(FireSpawn());
                // Destroy(spawnsFireonPlayer, 3);
                StartCoroutine(Statuses());
                break;
            case FireBossStatus.ATTACK_2:
                anim.SetTrigger("attack02");
                Instantiate(fireAttack, ballsPOSU.position, Quaternion.identity);
                Instantiate(fireAttack, ballsPOSD.position, Quaternion.identity);
                Instantiate(fireAttack, ballsPOSR.position, Quaternion.identity);
                Instantiate(fireAttack, ballsPOSL.position, Quaternion.identity);

                Instantiate(fireAttack, ballsPOSL2.position, Quaternion.identity);
                Instantiate(fireAttack, ballsPOSR2.position, Quaternion.identity);
                Instantiate(fireAttack, ballsPOSUD.position, Quaternion.identity);
                Instantiate(fireAttack, ballsPOSDR.position, Quaternion.identity);


              

                StartCoroutine(Statuses());
                break;
            
        }


    }

   



}
