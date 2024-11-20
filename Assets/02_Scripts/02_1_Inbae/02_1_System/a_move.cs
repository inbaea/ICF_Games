using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class RigidbodyMove : MonoBehaviour
{
    Rigidbody2D rb;
    float speed = 5f;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector3 getVel = new Vector3(1f, -0.7f, 0) * speed;
        rb.velocity = getVel;
    }
}