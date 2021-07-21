using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCash : MonoBehaviour
{
    public GameObject Obj;
    public Transform SpawnPos;
    private float SpawnTime;
    void Start()
    {
        SpawnTime = Random.Range(3f, 7.2f);
    }
    
    void Update()
    {
        SpawnTime -= Time.deltaTime;

        if(SpawnTime <= 0)
        {
            Vector2 pos = new Vector2(Random.Range(-2.765f, 1.129f), Random.Range(0.374f, -1.825f)); 
            Instantiate(Obj, pos, Quaternion.identity);
            SpawnTime = Random.Range(3.1f, 7.3f);
        }
    }
}
