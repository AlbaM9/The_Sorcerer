using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogosBehaveur : MonoBehaviour
{
    public DogoStatus fBStatus;
    public Animator anim;
    public float statCh;

    public bool beingDamaged;
    public GameObject bone;
    public Transform spawnbone;

    public GameObject dogoEye;
    public GameObject attackDetector;
    public enum DogoStatus
    {

        IDLE,
        ATTACK_1,
        DEATH


    }

    void Start()
    {
        fBStatus = DogoStatus.IDLE;
        anim = GetComponent<Animator>();
        
        StartCoroutine(Statuses());
        dogoEye.SetActive (false);
        attackDetector.SetActive(true);
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
                fBStatus = DogoStatus.IDLE;
                break;
            case 2:
                fBStatus = DogoStatus.ATTACK_1;
                break;


        }
        StatusChanger();
    }
    public void StatusChanger()
    {
        switch (fBStatus)
        {

            case DogoStatus.IDLE:

                attackDetector.SetActive(true);
                anim.SetBool("Attack", false);
                StartCoroutine(Statuses());

                /*    if (beingDamaged == true)
                    {

                        Debug.Log("No puedo atacarte");

                    }
                    else 
                    {
                        fBStatus = DogoStatus.ATTACK_1;
                        StartCoroutine(Statuses());
                    }*/

                break;
            case DogoStatus.ATTACK_1:
                attackDetector.SetActive(false);
                anim.SetBool("Attack", true);
                dogoEye.SetActive(true);

                StartCoroutine(Timer());
                StartCoroutine(Statuses());
                break;


        }

    }


   

    IEnumerator Timer()
    {

        yield return new WaitForSeconds(1);
        Instantiate(bone, spawnbone.position, Quaternion.identity);
        yield return new WaitForSeconds(1.5f);
        dogoEye.SetActive(false);
        //hay que poner en el target el script de vida y daños del chucho.
        //if tag de cada bicho se instancia un hueso distinto; Va a haber 4 huesos de los 4 elementos;
    }
    
    
}
