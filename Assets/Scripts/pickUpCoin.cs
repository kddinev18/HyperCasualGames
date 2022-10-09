using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickUpCoin : MonoBehaviour
{
    public int coins = 0;
    public int InGameCoins = 0;
    public Text coinText;
    public ParticleSystem ps;

    void Update()
    {
        coinText.text = coins.ToString();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Coin")
        {
            StartCoroutine(wait());
            Vibration.Vibrate(30);
            Destroy(other.gameObject);
            coins++;
        }
        else if (other.gameObject.tag == "Diamond")
        {
            Vibration.Vibrate(60);
            Destroy(other.gameObject);
            InGameCoins++;
        }
    }

    IEnumerator wait()
    {
        ps.enableEmission = true;
        yield return new WaitForSeconds(0.20f);
        ps.enableEmission = false;
    }
}
