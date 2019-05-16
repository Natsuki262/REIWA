using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_bullet : MonoBehaviour
{
    private CircleCollider2D col;
    private Rigidbody2D rb;
    [SerializeField]
    private float Ex_bulletSpeed;

    public float Radius
    {
        get { return col.radius; }
        set { col.radius = value; }
    }
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<CircleCollider2D>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveBullet();
    }
    void MoveBullet()
    {
       rb.velocity = transform.up.normalized *Ex_bulletSpeed* Time.deltaTime;
        //transform.Translate(0, 0.5f, 0);
        if (transform.position.y > 5)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        var clingObj = collision.transform.GetComponent<Enemy>();
        if (collision.gameObject.tag == "Enemy")
        {
            if(clingObj)
            {
                clingObj.TryCling(this);
            }

        }
    }
}
