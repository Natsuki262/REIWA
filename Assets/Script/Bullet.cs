using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    float bulletSpeed;
    // Start is called before the first frame update
    void Start()
    {
        MoveBullet();

    }

    void MoveBullet()
    {
        GetComponent<Rigidbody2D>().velocity = transform.up * bulletSpeed * Time.deltaTime;
        if (transform.position.y > 5)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);

        }
    }

}
