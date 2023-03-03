using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWall : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _CanDeleteWall;
    [SerializeField] CanSpawn _canSpawn;

    private void Start()
    {
       
    }



    void Update()
    {
        transform.Translate(Vector2.down * _speed * Time.deltaTime);


        if (gameObject.transform.position.y <= _CanDeleteWall)
        {
           
            Destroy(gameObject);
        }
    }
}
