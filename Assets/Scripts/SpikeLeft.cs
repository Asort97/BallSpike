using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeLeft : MonoBehaviour
{

    void Start()
    {   
        StartCoroutine(wait());
        IEnumerator wait() {
            yield return new WaitForSeconds(10f);
            Destroy(gameObject);
        }
    }
}
