using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_House : MonoBehaviour
{
    public GameObject child;

    void Start()
    {
        child = transform.GetChild(0).gameObject;
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll != child.GetComponent<Collider2D>())
        {
            Physics2D.IgnoreCollision(coll, gameObject.GetComponent<Collider2D>());
        }
    }
}
