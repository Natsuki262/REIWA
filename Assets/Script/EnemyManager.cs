using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    
    public GameObject enemy_heisei;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Arrival", 1, 1);
       
    }

    // Update is called once per frame
    void Update()
    {
       // Arrival();
    }
    void Arrival()  //敵の出現関数
    {
        Instantiate(enemy_heisei, new Vector3(-5f + 8 * Random.value, 10, 0), Quaternion.identity);
    }
}
