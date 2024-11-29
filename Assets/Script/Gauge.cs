using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Gauge : MonoBehaviour
{
    public float maxCount = 100;
    private float pluscount;
    public EnemyShop enemyShop;
    public Gauge hgauge;
    void Start()
    {
        enemyShop = GetComponent<EnemyShop>();   
    }

    void Update()
    {
     
    }
}
