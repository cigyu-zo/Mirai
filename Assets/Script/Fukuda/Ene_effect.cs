using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ene_effect : MonoBehaviour
{
    private GameObject parent;
    EnemyShop enemyShop;

    [SerializeField]
    [Tooltip("Ene_Hissatu")]
    private ParticleSystem paticle;

    // Start is called before the first frame update
    void Start()
    {
        parent = this.gameObject.transform.parent.gameObject;
        enemyShop = parent.GetComponent<EnemyShop>();
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyShop.cooltime == 100)
        {
            ParticleSystem newpaticle = Instantiate(paticle);
            newpaticle.transform.position = this.transform.position;
            newpaticle.Play();
        }
    }
}
