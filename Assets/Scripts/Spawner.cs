using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    public GameObject enemy2;
    public GameObject enemy3;

    private int enemyRandom;
    private int randY;
    private Vector3 whereToSpawn;
    public float spawnRate = 1f;
    private float nextSpawn = 0f;
    private float before;

    private float[] arr = { -1.325f, 0f, 1.325f };

    void Update()
    {
        if(Time.time > nextSpawn)
        {
            spawn();
        }
    }

    void spawn()
    {
        nextSpawn = Time.time + spawnRate;
        randY = Random.Range(0, 3);
        if (before == arr[randY])
        {
            spawn();
        }
        else
        {
            before = arr[randY];
            whereToSpawn = new Vector3(transform.position.x, arr[randY], 6.75f);
            enemyRandom = Random.Range(1, 6);
            if (enemyRandom == 1 || enemyRandom == 2)
            {
                Instantiate(enemy, whereToSpawn, enemy.transform.rotation);
            }
            else if(enemyRandom == 3 || enemyRandom == 4)
            {
                Instantiate(enemy2, whereToSpawn, enemy2.transform.rotation);
            }
            else if (enemyRandom == 5 || enemyRandom == 6)
            {
                Instantiate(enemy3, whereToSpawn, enemy3.transform.rotation);
            }
            else if (enemyRandom == 7)
            {

            }
        }
    }
}
