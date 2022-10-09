using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public Transform transform;
    public float speed = 2.5f;
    void Update()
    {
        transform.position += new Vector3(speed, 0.0f, 0.0f) * Time.deltaTime * -1;
        if(transform.position.x <= -5)
        {
            Destroy(this.gameObject);
        }
    }
}
