using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private int speed;
    [SerializeField] private Vector2 _target;
    [SerializeField] private float _max, _min, srednee;
    [SerializeField] private Transform _startPosition;
    [SerializeField] private float _area;
    

    [SerializeField] private LayerMask _mask;
    

    [SerializeField] private float StartSpawn;
    [SerializeField] private float EndSpawn;
    private CanSpawn _canSpawn;


    [SerializeField] private Transform _originPosition;
    [SerializeField] private float _distens;
    [SerializeField] private SpawnObstacles _spawnObstacles;

   


    void Start()
    {
        _spawnObstacles = FindObjectOfType<SpawnObstacles>();
        _canSpawn = FindObjectOfType<CanSpawn>();
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D Wall = Physics2D.OverlapCircle(_startPosition.position, _area, _mask);
       
            if (Input.GetKeyDown(KeyCode.A) && Wall)
            {

                _target = new Vector2(_min, transform.position.y);
                gameObject.transform.localRotation = Quaternion.Euler(0, 0, 90);


            }
            else if (Input.GetKeyDown(KeyCode.D) && Wall)
            {
                _target = new Vector2(_max, transform.position.y);
                gameObject.transform.localRotation = Quaternion.Euler(0, 0, 270);

            }
        
        

        transform.position = Vector2.MoveTowards(transform.position, _target, speed * Time.deltaTime);











        if(StartSpawn <= 0 )
        {
            _canSpawn.Spawn1();
            _spawnObstacles.SpawnerObsracles();
            StartSpawn = EndSpawn;
        }
        else
        {
            StartSpawn -= Time.deltaTime;
        }
        
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(_startPosition.position, _area);
        Gizmos.DrawWireSphere(_startPosition.position, _area);
    }
}
