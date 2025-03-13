using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class RigidbodyMove : MonoBehaviour
{
    //���� ȭ�鿡�� ���� ĳ���Ͱ� �밢�� �������� �ȴµ��� ȿ���� �ִ� ��ũ��Ʈ�Դϴ�.
    //speed ������ �̿��� �ӵ��� ������ �� �ְ�, new Vector3() �κ��� ������ ������ ������ �� �ֽ��ϴ�.
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