using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loading_Bar : MonoBehaviour
{
    //�ε� ȭ�鿡 �ܵ� Ÿ���� ���������� �̵��ϴ� ȿ���� ���� ��ũ��Ʈ�Դϴ�.
    //speed ������ ������ �ӵ��� ������ �� �ֽ��ϴ�.
    Rigidbody2D rb;
    float speed = 200f;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector3 getVel = new Vector3(1, 0, 0) * speed;
        rb.velocity = getVel;
    }
}
