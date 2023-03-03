using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnuObstacles : MonoBehaviour
{
    public GameObject spawn;
    void Start()
    {
        Instantiate(spawn, gameObject.transform.position, Quaternion.identity);
    }
    

    
}
