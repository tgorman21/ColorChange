using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plague : MonoBehaviour
{
    Rigidbody2D rb;
    public float rand;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rand = Random.Range(-1, 1);
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb.AddForce(Vector2.right * rand);
        if (collision.gameObject.GetComponent<CircleCollider2D>() == true)
        {
            collision.gameObject.tag = this.tag;
        }
        else if (collision.gameObject.GetComponent<CircleCollider2D>() == null)
        {

        }
    }
}
