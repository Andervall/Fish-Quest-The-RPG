using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMover : MonoBehaviour {

    private Rigidbody2D rb;

    public float speed;
    public float maxSpeed;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        
        //rb.velocity = transform.forward * speed;
    }

    // Update is called once per frame
    void Update () {
        rb.AddForce((Vector2.right * speed) * 1);
        if (rb.velocity.x > maxSpeed)
        {
            rb.velocity = new Vector2(maxSpeed, rb.velocity.y);
        }
    }
}
