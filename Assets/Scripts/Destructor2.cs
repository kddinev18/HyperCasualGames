using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destructor2 : MonoBehaviour
{
    [SerializeField] private camerashaker cshaker;
    public bool death = false;
    [SerializeField] private ParticleSystem ps;
    [SerializeField] private ParticleSystem ps2;
    [SerializeField] private SpriteRenderer player;
    [SerializeField] private TrailRenderer trailRenderer;
    [SerializeField] private Animator anim1;
    [SerializeField] private Animator anim3;
    [SerializeField] private movePlayer moveplayer;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy" && !death)
        {
            moveplayer.isStarted = false;
            Vibration.Vibrate(100);
            death = true;
            StartCoroutine(wait());
            ps.transform.position = this.transform.position;
        }
    }

    IEnumerator wait()
    {
        StartCoroutine(cshaker.Shake(0.30f, 0.15f));
        ps.Play();
        ps2.Stop();
        player.enabled = false;
        trailRenderer.enabled = false;
        yield return new WaitForSeconds(0.5f);
        anim1.SetBool("endText", true);
        yield return new WaitForSeconds(1.5f);
        anim3.SetBool("EndScene", true);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
    }
}
