using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] ShipsMassive;

    public float TimeForNextSpawn;
    public float minTime;
    public float maxTime;

    private void Update()
    {
        int i = Random.Range(0, ShipsMassive.Length);
        if(TimeForNextSpawn <= 0)
        {
            Instantiate(ShipsMassive[i], transform.position, Quaternion.identity);
            TimeForNextSpawn = Random.Range(minTime, maxTime);
        }
        else
        {
            TimeForNextSpawn -= Time.deltaTime;
        }
    }
}
