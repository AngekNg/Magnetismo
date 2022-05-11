using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrictionController : MonoBehaviour
{
    bool touching = false;
    Rigidbody2D rb;
    GameObject snapTo;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(touching)
        {
            rb.velocity = Vector2.Lerp(rb.velocity,new Vector2(0f,0f),0.05f);
            transform.position = Vector3.Lerp(transform.position, snapTo.transform.position, 0.1f) ;
        }
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag =="Magnet" && other)
        {
            touching=true;
            snapTo = other.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        touching=false;
    }
}
