using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throws : MonoBehaviour
{
    Rigidbody2D rb;
    public float power;
    public float float_x;
    public float float_y;
    public float waitTime;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        StartCoroutine(Throwsitem());
    }

    IEnumerator Throwsitem()
    {
        yield return new WaitForSeconds(waitTime);
        Vector3 vec = new Vector3 (float_x, float_y, 0);
        rb.AddForce(vec * power);
        yield return null;
    }
}
