using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitVelocity : MonoBehaviour
{
    private Rigidbody2D rb;

    public float maxVelocity;
    // Start is called before the first frame update
    void Start()
    {
        rb = transform.root.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /*
        if (rb.velocity.magnitude > maxVelocity)
            rb.velocity = rb.velocity.normalized * maxVelocity;
        */
        if (Mathf.Abs(rb.velocity.x) > maxVelocity)
            rb.velocity = new Vector2(maxVelocity * Mathf.Sign(rb.velocity.x), rb.velocity.y);
    }
}
