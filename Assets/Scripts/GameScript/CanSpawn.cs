using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanSpawn : MonoBehaviour
{
    public GameObject SpawnPrefab;
   

   


    public void Spawn1()
    {
        
            Instantiate(SpawnPrefab);
           
        
       
    }
}
