using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnRate = 1f;
    public GameObject hexagonPrefab;

    private float NextTimeToSpwan = 0f;
    void Update()
    {
        if(Time.time >= NextTimeToSpwan)  
        {
            Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity);
            NextTimeToSpwan = Time.time + 1f / spawnRate;
        }
    }
}
