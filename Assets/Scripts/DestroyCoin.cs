using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCoin : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 11.5f);
    }
}
