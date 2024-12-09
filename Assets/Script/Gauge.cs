using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Gauge : MonoBehaviour
{
    public EnemyShop enemyShop;
    public GameObject parentObj;
    [SerializeField] Slider Hissatu;
    float dashPoint;
    void Start()
    {
        dashPoint = enemyShop.cooltime;
        Hissatu.maxValue = enemyShop.cooltime;
        Hissatu.value = enemyShop.cooltime;
        enemyShop = GameObject.Find("Ene_Store").GetComponent<EnemyShop>();
    }

    void Update()
    {
        Hissatu.value = enemyShop.count;
     if(dashPoint < enemyShop.count)
     {
        dashPoint++;
     }
    }
}
