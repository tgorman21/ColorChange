using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Material [] mats;
    private Material material;
    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<SpriteRenderer>().material;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Green"))
        {
            GetComponent<SpriteRenderer>().material = mats[0];
            this.gameObject.tag = "Green";
        }
        else if (collision.gameObject.CompareTag("Blue"))
        {
            GetComponent<SpriteRenderer>().material = mats[1];
            this.gameObject.tag = "Blue";
        }
        else if (collision.gameObject.CompareTag("Yellow"))
        {
            GetComponent<SpriteRenderer>().material = mats[2];
            this.gameObject.tag = "Yellow";
        }
        else if (collision.gameObject.CompareTag("Purple"))
        {
            GetComponent<SpriteRenderer>().material = mats[3];
            this.gameObject.tag = "Purple";
        }
        else if (collision.gameObject.CompareTag("White"))
        {
            GetComponent<SpriteRenderer>().material = mats[4]; 
            this.gameObject.tag = "White";
        }
    }
}
