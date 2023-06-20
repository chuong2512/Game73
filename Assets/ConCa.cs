using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConCa : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Trigger");
       GetComponent<Animator>().SetTrigger("Win");

       StartCoroutine(wwin());
       
       IEnumerator wwin()
       {
           yield return new WaitForSeconds(4);
           TheGameUI.Instance.ShowWin();
       }
    }
}
