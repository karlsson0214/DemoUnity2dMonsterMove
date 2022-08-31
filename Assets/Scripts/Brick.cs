using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    private Vector3 speed = new Vector3(5, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime);
        if (transform.position.x > 5)
        {
            speed = new Vector3(-5, 0, 0);
        }
        else if (transform.position.x < -5)
        {
            speed = new Vector3(5, 0, 0);
        }
        
    }
}
