using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject[] Variant;
    int rand;
    public void SpawnerObsracles()
    {
        rand = Random.Range(0, Variant.Length);
        Instantiate(Variant[rand]);
    }

   
}
