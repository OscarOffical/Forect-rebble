using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TakeDamag : MonoBehaviour
{
    private HealthPlayer healthPlayer;
    private EnemyDamag  enemyDamag;
    [SerializeField] Image[] FullHealth;
    [SerializeField] private Sprite _spriteEmptyHealth;



    private void Start()
    {
        healthPlayer = FindObjectOfType<HealthPlayer>();
        enemyDamag= FindObjectOfType<EnemyDamag>();
      

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {

                FullHealth[healthPlayer._health -1].sprite = _spriteEmptyHealth;
                healthPlayer._health -= enemyDamag.damag;

            }
        }
    }
}
