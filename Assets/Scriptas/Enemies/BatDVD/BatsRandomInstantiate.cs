using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatsRandomInstantiate : MonoBehaviour
{
    public GameObject[] bossSpawn = new GameObject[16];
    public GameObject[] porraEnemy = new GameObject[10];


    public Transform spawnBoss;
    public Transform spawnBoss2;
    public Transform spawnBoss3;
    public Transform spawnBoss4;

    public Transform spawnFlea1;
    public Transform spawnFlea2;

    public GameObject earthBoss;
    public GameObject waterBoss;
    public GameObject fireBoss;
    public GameObject airBoss;
    public GameObject laserFleas;


    public GameObject uno;
    public GameObject zero;

    private GameObject instan;
    private GameObject result;

    public ItemRoomDoors doors;


    void Start()
    {
        doors = FindObjectOfType<ItemRoomDoors>();
        int porra = Random.Range(0, 9);

        porraEnemy[0] = uno;
        porraEnemy[1] = zero;
        porraEnemy[2] = zero;
        porraEnemy[3] = uno;
        porraEnemy[4] = zero;
        porraEnemy[5] = uno;
        porraEnemy[6] = zero;
        porraEnemy[7] = uno;
        porraEnemy[8] = zero;
        porraEnemy[9] = uno;

        result = porraEnemy[porra];

        if (result == uno)
        {
            doors.enemiesDead = 4;
            int numero = Random.Range(0, 15);

            bossSpawn[0] = earthBoss;
            bossSpawn[1] = waterBoss;
            bossSpawn[2] = fireBoss;
            bossSpawn[3] = airBoss;

            bossSpawn[4] = earthBoss;
            bossSpawn[5] = waterBoss;
            bossSpawn[6] = fireBoss;
            bossSpawn[7] = airBoss;

            bossSpawn[8] = earthBoss;
            bossSpawn[9] = waterBoss;
            bossSpawn[10] = fireBoss;
            bossSpawn[11] = airBoss;

            bossSpawn[12] = earthBoss;
            bossSpawn[13] = waterBoss;
            bossSpawn[14] = fireBoss;
            bossSpawn[15] = airBoss;








            instan = bossSpawn[numero];



            Instantiate(instan, spawnBoss.position, Quaternion.identity);
            Instantiate(instan, spawnBoss2.position, Quaternion.identity);
            Instantiate(instan, spawnBoss3.position, Quaternion.identity);
            Instantiate(instan, spawnBoss4.position, Quaternion.identity);

        } else
        {
            doors.enemiesDead = 2;
            Instantiate(laserFleas, spawnFlea1.position, Quaternion.Euler(0, 180, 0));
            Instantiate(laserFleas, spawnFlea2.position, Quaternion.identity);


        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
