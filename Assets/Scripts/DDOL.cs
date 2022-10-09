using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDOL : MonoBehaviour
{
    private static DDOL instance = null;
    public static DDOL Instance
    {
        get { return instance; }
    }
    void Awake()
    {
        if (instance != null && instance != this) {
            Destroy(this.gameObject);
            return;
        } else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
