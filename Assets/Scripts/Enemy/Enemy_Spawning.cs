using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawning : MonoBehaviour
{
    public GameObject[] spawnPoints;
    GameObject currentPoint;
    int index;

    public GameObject[] enemies;
    public float minTimeSpawns;
    public float maxTimeSpawns;
    public bool canSpawn;
    public float spawnTime;
    public int enemiesInRoom;
    public bool spawnerDone;
    //public GameObject spawnerDoneGameObject;

    //public GameObject Nest;
    private SpriteRenderer NestRender;

    public GameObject InvasionTrigger;
    private bool x;
    private bool InvT;

    private void Start()
    {
        x = true;
        //Nest = GameObject.Find("Nest");
        InvasionTrigger = GameObject.Find("Invasion_Trigger");
        //NestRender = Nest.GetComponent<SpriteRenderer>();
        Invoke("SpawnEnemy", 0.5f);
    }

    private void Update()
    {
        InvT = InvasionTrigger.GetComponent<Detector>().playerDetected;
        if (InvT && x)
        {
            StartCoroutine(Delay());
            x = false;
        }
        if (canSpawn)
        {
            spawnTime -= Time.deltaTime;
            if(spawnTime <= 0)
            {
                canSpawn = false;
            }
        }
    }

    void SpawnEnemy()
    {
        index = Random.Range(0, spawnPoints.Length);
        currentPoint = spawnPoints[index];
        float timeSpawns = Random.Range(minTimeSpawns, maxTimeSpawns);

        if (canSpawn)
        {
            Instantiate(enemies[Random.Range(0, enemies.Length)], currentPoint.transform.position, Quaternion.identity);
            enemiesInRoom++;
        }

        Invoke("SpawnEnemy", timeSpawns);
        //if (spawnerDone)
        //{
        //    NestRender.enabled = false;
        //}
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(19f);
        canSpawn = InvT;
    }
}
