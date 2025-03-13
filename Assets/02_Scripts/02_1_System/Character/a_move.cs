using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class RigidbodyMove : MonoBehaviour
{
    //시작 화면에서 남자 캐릭터가 대각선 방향으로 걷는듯한 효과를 주는 스크립트입니다.
    //speed 변수를 이용해 속도를 조절할 수 있고, new Vector3() 부분을 수정해 방향을 조정할 수 있습니다.
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