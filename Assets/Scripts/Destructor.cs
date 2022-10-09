using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destructor : MonoBehaviour
{
    public int index;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + index);
        }
    }
}
