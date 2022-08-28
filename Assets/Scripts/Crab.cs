using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CapsuleCollider2D))]

public class Crab : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed = 4;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // Physics enginge will not rotate Crab
        rb.freezeRotation = true;
        // remove gravity
        rb.gravityScale = 0;
        rb.velocity = new Vector2(speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // reset speed
        float angleRadians = rb.rotation * Mathf.PI / 180f;
        float xSpeed = Mathf.Cos(angleRadians) * speed;
        float ySpeed = Mathf.Sin(angleRadians) * speed;
        rb.velocity = new Vector2(xSpeed, ySpeed);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // back up - to prevent colliders from overlapping
        transform.position -= transform.right.normalized * speed * Time.deltaTime * 2;

        // random left och right
        if (Random.Range(0, 2) == 0)
        {
            // turn left
            rb.rotation += Random.Range(40, 90);
        }
        else
        {
            // turn right
            rb.rotation -= Random.Range(40, 90);
        }
        
        // reset speed
        float angleRadians = rb.rotation * Mathf.PI / 180f;
        float xSpeed = Mathf.Cos(angleRadians) * speed;
        float ySpeed = Mathf.Sin(angleRadians) * speed;
        rb.velocity = new Vector2(xSpeed, ySpeed);
    }
}
