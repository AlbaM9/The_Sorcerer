using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VenusDPS : MonoBehaviour
{
    public float vida;
    

    public bool isBurning;

    private Renderer rend;
    public Color originalColor;
    public Color selectedColor = Color.red;

    void Start()
    {
        vida = 30;
       

        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //el ISBURNING NO FUNCIONA
    }

    public IEnumerator VenusDPs()
    {

        // recibe un porcentaje de daño de forma pasiva durante 3 segundos

        rend.material.color = selectedColor;
        vida -= 0.5f * Time.deltaTime;
        Debug.Log("Llegas?");
        yield return new WaitForSeconds(3f);
        rend.material.color = originalColor;
        isBurning = false;



    }
}
