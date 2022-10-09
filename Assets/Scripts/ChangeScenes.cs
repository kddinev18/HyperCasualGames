using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    public Text text;
    public SpeedIncreacer speedincreacer;
    public spawnCoins spawncoins;
    public Spawner spawner;
    public bool canPress = false;
    public bool canPresses = true;


    public void Play()
    {
        canPresses = false;
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(0.2f);
        canPress = true;
        text.gameObject.SetActive(false);
        speedincreacer.enabled = true;
        spawncoins.enabled = true;
        spawner.enabled = true;
    }
}
