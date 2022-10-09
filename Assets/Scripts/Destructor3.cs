using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructor3 : MonoBehaviour
{
    public bool death = false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy" && !death)
        {
            death = true;
            Debug.Log("game has edned");
            //end game
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
