using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public Animator anim1;
    public void minigame1()
    {
        StartCoroutine(wait(1));
    }

    public void minigame2()
    {
        StartCoroutine(wait(2));
    }

    IEnumerator wait(int index)
    {
        anim1.SetBool("EndScene", true);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + index);
    }
}
