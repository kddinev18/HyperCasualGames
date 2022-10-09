using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class stopgame : MonoBehaviour
{
    public movePlayer moveplayer;
    public GameObject button;
    public soawnenemyhor Soawnenemyhor;
    public Image backbutton;

    public void press()
    {
        backbutton.enabled = false;
        StartCoroutine(waiter());
    }
    IEnumerator waiter()
    {
        moveplayer.isStarted = true;
        Soawnenemyhor.enabled = true;
        yield return new WaitForSeconds(0.2f);
        Destroy(button.gameObject);
    }
    public Animator anim3;

    public void BackMenu()
    {
        StartCoroutine(wait());
    }

    IEnumerator wait()
    {
        anim3.SetBool("EndScene", true);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadSceneAsync("Main Menu");
    }
}
