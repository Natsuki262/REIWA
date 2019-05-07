using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    float FallSpeed;
    [SerializeField]
    public GameObject Explosion;//爆発エフェクトのプレハブ

   

    public int scoreValue;
    private ScoreManager sm;
    // Start is called before the first frame update
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
    }
}
