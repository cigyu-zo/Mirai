using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gauge : MonoBehaviour
{
    public float maxCount = 100;
    private float pluscount;
    public GameObject enemyshop;
    // Start is called before the first frame update
    void Start()
    {
        pluscount = maxCount;
        UpdateGauge();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void UpdateGauge()
    {
     
    }
}
