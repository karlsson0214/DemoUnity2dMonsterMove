using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
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
    }
    private void OnCollisionEnter2D()
    {
        speed *= -1;
        //speed = new Vector3(-5, 0, 0);
        Debug.Log("collision");

    }
}
