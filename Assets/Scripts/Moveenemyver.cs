using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveenemyver : MonoBehaviour
{
    public Transform transform;
    public float speed = 2.5f;
    void Update()
    {
        transform.position += new Vector3(0.0f, speed, 0.0f) * Time.deltaTime * -1;
        if (transform.position.y <= -5.75f)
        {
            Destroy(this.gameObject);
        }
    }
}
