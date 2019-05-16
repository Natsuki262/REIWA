using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    float FallSpeed;
    [SerializeField]
    public GameObject Explosion;//爆発エフェクトのプレハブ
    public GameObject Experimental_bullet;
    private CircleCollider2D col;
    private Rigidbody2D rb;

    [SerializeField]
    private float bulletRadius = 0;

    public int scoreValue;
    private ScoreManager sm;


    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<CircleCollider2D>();

    }
    void Start()
    {
        //FallSpeed = 0.1f + 0.1f * Random.value;
        sm = GameObject.Find("Score").GetComponent<ScoreManager>();
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
            Instantiate(Explosion, collision.transform.position, Quaternion.identity);
            sm.AddScore(scoreValue);
        }
        if (collision.gameObject.tag == "Ex_bullet")
        {
            //Destroy(gameObject);
            //Instantiate(Explosion, collision.transform.position, Quaternion.identity);
            //sm.AddScore(scoreValue);
            
        }

    }

   

   /* public void Create_Parent(Transform newParent)
    {
        gameObject.transform.SetParent(newParent);
        //Experimental_bullet.transform.SetParent(newParent, false);
    }*/
    public void TryCling(Ex_bullet exBullet)
    {
       if(exBullet.Radius>bulletRadius)
        {
            transform.parent = exBullet.transform;
            rb.isKinematic = true;
          

        }
    }
}
