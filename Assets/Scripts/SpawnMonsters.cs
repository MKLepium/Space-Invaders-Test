using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMonsters : MonoBehaviour {

    public GameObject Monster1;
    public GameObject Monster2;
    public float Intervall = 3;

    void Start()
    {

            InvokeRepeating("spawnMonster", Intervall, Intervall);
        
        
    }
    void spawnMonster()
    {
        GameObject gaOb = GameObject.FindWithTag("Player");
        if (gaOb != null)
        {
            float v = Random.value;
            if (v < 0.30)
            {
                GameObject g = Instantiate(Monster1, transform.position, Quaternion.identity);
            }
            if (v > 0.7)
            {
                GameObject g = Instantiate(Monster2, transform.position, Quaternion.identity);
            }
        }
    }
}
