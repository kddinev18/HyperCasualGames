using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoateEnimy : MonoBehaviour
{
    public Transform transform;
    public float speedRotate = 90;
    private int wayOfRotating = 1;
    private int wayOfRotatingR;

    void Start()
    {
        wayOfRotatingR = Random.Range(0, 1);
        if(wayOfRotatingR == 0)
        {
            wayOfRotating = -1;
        }
        else
        {
            wayOfRotating = 1;
        }
    }

    void Update()
    {
        transform.Rotate(Vector3.forward * speedRotate * Time.deltaTime * wayOfRotating);
    }
}
