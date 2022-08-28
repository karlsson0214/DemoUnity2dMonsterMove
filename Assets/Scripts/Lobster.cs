using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CircleCollider2D))]
public class Lobster : MonoBehaviour
{
    private float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        // not rotated by the Physics engine
        rb.freezeRotation = true;
        // not effected by gravity
        rb.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // move forward
        transform.position += transform.right.normalized * speed * Time.deltaTime;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // rotate 30 degrees anticlockwise
        transform.rotation *= Quaternion.AngleAxis(30, Vector3.forward);
    }
}
