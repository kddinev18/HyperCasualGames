using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movePlayer : MonoBehaviour
{
    public float speed;
    public Transform playertransform;
    private int wayOfWalking = 1;
    private float timeMax = 5f;
    private bool canHold = true;
    public Transform timebar;
    private bool isPressing=false;
    private float timeToRefil = 0.025f;
    public TrailRenderer trailRenderer;
    public int coin = 0;
    public Text text;
    public bool isStarted = false;
    public AudioSource audioSource;
    void Start()
    {
        StartCoroutine(waiter());
    }

    void Update()
    {
        if (isStarted)
        {
            timeToRefil -= Time.deltaTime;
            if (timeToRefil <= 0 && timebar.localScale.y < 10.1f && !isPressing)
            {
                timeMax += 0.005f;
                timeToRefil = 0.01f;
                canHold = true;
            }
            if (Input.GetMouseButton(0) && canHold)
            {
                isPressing = true;
                speed = 0.5f;
                timeMax -= Time.deltaTime;
                if (timeMax <= 0)
                {
                    canHold = false;
                    speed = 3f;
                }
            }
            else if (Input.GetMouseButtonUp(0))
            {
                isPressing = false;
                speed = 3f;
            }
            timebar.localScale = new Vector3(6.4f, (timeMax) * 2, 1f);
        }
            transform.position += new Vector3(speed, 0.0f, 0.0f) * Time.deltaTime * wayOfWalking;
            text.text = coin.ToString();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Left")
        {
            wayOfWalking = 1;
            if (isStarted)
            {
                audioSource.Play();
                coin++;
            }
        }
        else if (other.gameObject.tag == "Right")
        {
            wayOfWalking = -1;
            if (isStarted)
            {
                audioSource.Play();
                coin++;
            }
        }
    }

    IEnumerator waiter()
    {
        trailRenderer.enabled = false;
        yield return new WaitForSeconds(1.50f);
        trailRenderer.enabled = true;
    }
}
