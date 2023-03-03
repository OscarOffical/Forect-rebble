using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HealthPlayer : MonoBehaviour
{
   
    public  int _health;
    [SerializeField] private GameObject deadPanel;
    [SerializeField] private AmountBoul amountBoul;

    private void Start()
    {
        amountBoul=FindObjectOfType<AmountBoul>();
    }

    private void Update()
    {
        if (_health <= 0)
        {
          gameObject.SetActive(false);
          deadPanel.SetActive(true);
          amountBoul.enabled = false;
        }
        else
        {
            deadPanel.SetActive(false);
        }
    }







}
