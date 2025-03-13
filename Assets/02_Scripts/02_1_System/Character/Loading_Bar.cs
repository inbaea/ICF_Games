using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loading_Bar : MonoBehaviour
{
    //로딩 화면에 잔디 타일이 오른쪽으로 이동하는 효과를 넣은 스크립트입니다.
    //speed 변수를 수정해 속도를 조절할 수 있습니다.
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
