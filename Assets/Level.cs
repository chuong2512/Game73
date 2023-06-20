using System.Collections;
using System.Collections.Generic;
using RObo;
using UnityEngine;

public class Level : Singleton<Level>
{
    public GameObject hide;
    // Start is called before the first frame update
    void Start()
    {
        hide.SetActive(false);
    }
    
}