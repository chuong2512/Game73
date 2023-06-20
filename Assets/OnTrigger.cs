using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Water2D;

public class OnTrigger : MonoBehaviour
{
    public Water2D_Spawner Water2D;

    private bool isSpawn = false;

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log($"{col.gameObject.tag}");
        
        if (!isSpawn && !col.gameObject.CompareTag("Line"))
        {
            Debug.Log("Trigger");
            Water2D.Spawn();
            isSpawn = true;
        }
    }
}