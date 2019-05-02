using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField]
    int min;
    [SerializeField]
    int max;
    
    public GameObject enemy_heisei;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Arrival", 2.0f, 0.1f);
       
    }

    // Update is called once per frame
    void Update()
    {
       // Arrival();
    }
    void Arrival()  //敵の出現関数
    {
        Instantiate(enemy_heisei, new Vector3(-4.0f + 10 * Random.value, 6,3), Quaternion.identity);
    }
}
