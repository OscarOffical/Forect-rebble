using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AmountBoul : MonoBehaviour
{
    public int amountGlasses;
    public TMP_Text GlassesText;
    public float starttime = 1.5f;
    public float endtime = 1.5f;

    void Start()
    {
        amountGlasses = 0;
    }

    
    void Update()
    {
      
    
        if(starttime <= 0)
        {
            amountGlasses++;
            starttime = endtime;
        }
        else
        {
            starttime -= Time.deltaTime;
        }




        GlassesText.text = amountGlasses.ToString();
    }
}
