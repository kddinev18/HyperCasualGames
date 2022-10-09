using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnCoins : MonoBehaviour
{
    private Vector3 whereToSpawn;
    public GameObject coin;
    public GameObject InGameCoin;
    private GameObject spawnedInGameCoin;
    public GameObject pt;

    private float []yPos = { 1.371f, 1.2997f, 1.044f , 0.6919001f, 0.3660001f, 0f     , -0.4144f, -0.8286f, -1.1454f  , -1.3157f  , -1.379f, -1.3208f, -1.1294f, -0.7522999f, -0.3949999f, 0f      , 0.461f  , 0.816f  , 1.083f  , 1.288f };
    private float []XPos = { 0f    , 0.45f  , 0.8957f, 1.1923f   , 1.327f    , 1.3783f, 1.3146f , 1.1075f , 0.7606999f, 0.4071999f, 0f     , -0.4045f, -0.7923f, -1.1457f   , -1.32f     , -1.3774f, -1.2974f, -1.1054f, -0.8494f, -0.4844f };
    private int randPos;
    private float oldX;
    private float oldY;
    private int plusOrMins;
    public pickUpCoin pickupcoin;
    private int SpawnInGameCoin;

    void Start()
    {
        float x = pt.transform.position.x;
        float y = pt.transform.position.y;
        if (x > 0 && y > 0)
        {
            whereToSpawn = new Vector3(-1.1457f, -0.7522999f, 7f);
        }
        else if (x < 0 && y < 0)
        {
            whereToSpawn = new Vector3(1.1923f, 0.6919001f, 7f);
        }
        else if (x < 0 && y > 0)
        {
            whereToSpawn = new Vector3(1.1075f, -0.8286f, 7f);
        }
        else if (x > 0 && y < 0)
        {
            whereToSpawn = new Vector3(-0.8494f, 1.083f, 7f);
        }
        else if (x == 0 && y > 0)
        {
            whereToSpawn = new Vector3(0f, -1.379f, 7f);
        }
        else if (x == 0 && y < 0)
        {
            whereToSpawn = new Vector3(0f, 1.371f, 7f);
        }
        else if (x > 0 && y == 0)
        {
            whereToSpawn = new Vector3(-1.3774f, 0f, 7f);
        }
        else if (x < 0 && y == 0)
        {
            whereToSpawn = new Vector3(1.3783f, 0f, 7f);
        }
        //randPos = Random.Range(0, 20);
        //whereToSpawn = new Vector3(XPos[(randPos + 10) % 20], yPos[(randPos + 10) % 20], 7f);
        oldX = XPos[(randPos + 10) % 20];
        oldY = XPos[(randPos + 10) % 20];
        Instantiate(coin, whereToSpawn, coin.transform.rotation);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Coin" || other.gameObject.tag == "Diamond")
        {
            randPos = Random.Range(0, 20);
            SpawnInGameCoin = Random.Range(0,31);
            if (SpawnInGameCoin == 10)
            {
                whereToSpawn = new Vector3(XPos[randPos], yPos[randPos], 7f);
                spawnedInGameCoin = Instantiate(InGameCoin, whereToSpawn, InGameCoin.transform.rotation);
            }
            else
            {
                if (randPos < 5)
                {
                    if (XPos[randPos % 20] == oldX || XPos[(randPos + 1) % 20] == oldX || XPos[(randPos + 2) % 20] == oldX || XPos[(randPos + 3) % 20] == oldX)
                    {
                        whereToSpawn = new Vector3(XPos[(randPos + 7) % 20], yPos[(randPos + 7) % 20], 7f);
                        oldX = XPos[(randPos + 7) % 20];
                        oldY = XPos[(randPos + 7) % 20];
                        Instantiate(coin, whereToSpawn, coin.transform.rotation);
                    }
                    else
                    {
                        whereToSpawn = new Vector3(XPos[randPos], yPos[randPos], 7f);
                        oldX = XPos[randPos];
                        oldY = XPos[randPos];
                        Instantiate(coin, whereToSpawn, coin.transform.rotation);
                    }
                }
                else
                {
                    if (XPos[randPos % 20] == oldX || XPos[(randPos - 1) % 20] == oldX || XPos[(randPos + 1) % 20] == oldX || XPos[(randPos - 2) % 20] == oldX || XPos[(randPos + 2) % 20] == oldX || XPos[(randPos - 3) % 20] == oldX || XPos[(randPos + 3) % 20] == oldX)
                    {
                        whereToSpawn = new Vector3(XPos[(randPos + 7) % 20], yPos[(randPos + 7) % 20], 7f);
                        oldX = XPos[(randPos + 7) % 20];
                        oldY = XPos[(randPos + 7) % 20];
                        Instantiate(coin, whereToSpawn, coin.transform.rotation);
                    }
                    else
                    {
                        whereToSpawn = new Vector3(XPos[randPos], yPos[randPos], 7f);
                        oldX = XPos[randPos];
                        oldY = XPos[randPos];
                        Instantiate(coin, whereToSpawn, coin.transform.rotation);
                    }

                }
            }
        }
    }
}
