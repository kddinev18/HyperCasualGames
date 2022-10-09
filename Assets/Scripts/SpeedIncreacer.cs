using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedIncreacer : MonoBehaviour
{
    private float timeLeft = 3f;
    public RotatePlayer rotateplayer;
    public RoateEnimy rotateenemy;
    public MoveEnemy movenemy;
    public MoveEnemy movenemy1;
    public MoveEnemy movenemy2;
    public Spawner spawner;

    void Start()
    {
        movenemy.speed = 2.5f;
        movenemy1.speed = 2.5f;
        movenemy2.speed = 2.5f;
        rotateenemy.speedRotate = 90f;
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            IncreasePlayerSpeed();
            IncreaseEnemySpeed();
            IncreaseSpawnRate();
            timeLeft = 3f;
        }
    }

    void IncreasePlayerSpeed()
    {
        if (rotateplayer.speedRotate <= 100 && rotateplayer.speedRotate < 179)
        {
            rotateplayer.speedRotate += 1.5f;
        }
        else if (rotateplayer.speedRotate >= 100 && rotateplayer.speedRotate < 179)
        {
            rotateplayer.speedRotate += 2f;
        }
    }

    void IncreaseEnemyR()
    {
        if (rotateenemy.speedRotate <= 100 && rotateenemy.speedRotate < 179)
        {
            rotateplayer.speedRotate += 1.5f;
        }
        else if (rotateenemy.speedRotate >= 100 && rotateenemy.speedRotate < 179)
        {
            rotateplayer.speedRotate += 2f;
        }
    }

    void IncreaseEnemySpeed()
    {
        if (movenemy1.speed <= 5)
        {
            movenemy1.speed += 0.05f;
        }

        if (movenemy.speed <= 5)
        {
            movenemy.speed += 0.05f;
        }

        if (movenemy2.speed <= 5)
        {
            movenemy2.speed += 0.05f;
        }
    }

    void IncreaseSpawnRate()
    { 
        if (spawner.spawnRate <= 1 && spawner.spawnRate >= 0.35f)
        {
            spawner.spawnRate -= 0.01f;
        }
        else if (spawner.spawnRate <= 0.5f && spawner.spawnRate >= 0.35f)
        {
            spawner.spawnRate -= 0.02f;
        }
    }
}
