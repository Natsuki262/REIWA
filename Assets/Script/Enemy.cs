using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    float FallSpeed;
    // Start is called before the first frame update
    void Start()
    {
        //FallSpeed = 0.1f + 0.1f * Random.value;
    }

    // Update is called once per frame
    void Update()
    {

        Enemy_fall();
    }
    void Enemy_fall()
    {
        transform.Translate(0, -FallSpeed, 0);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            Destroy(gameObject);
        }
    }
}
