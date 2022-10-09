using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soawnenemyhor : MonoBehaviour
{
    public GameObject enemy;
    public GameObject enemy2;
    public GameObject enemy3;
    public Destructor2 destructor;

    private int enemyRandom;
    private int randX;
    private Vector3 whereToSpawn;
    public float spawnRate = 1f;
    private float nextSpawn = 0f;
    private float before;

    private float[] arr = { -1.1f, 0f, 1.1f };

    void Update()
    {
        if (Time.time > nextSpawn && !destructor.death)
        {
            spawn();
        }
    }

    void spawn()
    {
        nextSpawn = Time.time + spawnRate;
        randX = Random.Range(0, 3);
        if (before == arr[randX])
        {
            spawn();
        }
        else
        {
            before = arr[randX];
            whereToSpawn = new Vector3(arr[randX], 5.75f, 214f);
            enemyRandom = Random.Range(1, 6);
            if (enemyRandom == 1 || enemyRandom == 2)
            {
                Instantiate(enemy, whereToSpawn, enemy.transform.rotation);
            }
            else if (enemyRandom == 3 || enemyRandom == 4)
            {
                Instantiate(enemy2, whereToSpawn, enemy2.transform.rotation);
            }
            else if (enemyRandom == 5 || enemyRandom == 6)
            {
                Instantiate(enemy3, whereToSpawn, enemy3.transform.rotation);
            }
        }
    }
}
