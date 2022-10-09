using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlayer : MonoBehaviour
{
    public Transform transform;
    public float speedRotate = 90f;
    private int wayOfRotating = 1;
    private bool isPressedBefore = true;
    private int wORR;
    public TrailRenderer trailRenderer;
    public ChangeScenes changeScenes;

    void Start()
    {
        StartCoroutine(waiter());
        wORR = Random.Range(0, 2);
        if(wORR == 1)
        {
            wayOfRotating = -1;
            isPressedBefore = false;
        }
    }


    void Update()
    {
        if (SwipeManager.tap && changeScenes.canPress)
        {
            if (isPressedBefore)
            {
                wayOfRotating = -1;
                isPressedBefore = false;
            }
            else
            {
                wayOfRotating = 1;
                isPressedBefore = true;

            }
        }
        transform.Rotate(Vector3.forward * speedRotate * Time.deltaTime * wayOfRotating);
    }

    IEnumerator waiter()
    {
        trailRenderer.enabled = false;
        yield return new WaitForSeconds(0.50f);
        trailRenderer.enabled = true;
    }

}
