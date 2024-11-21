using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    Rigidbody2D r;
    public float bulletSpeed = 10; // 속도 값은 tank에서 조절됨

    void Start()
    {
        // Rigidbody2D 컴포넌트 가져오기, 없으면 추가
        r = GetComponent<Rigidbody2D>();
        if (r == null)
        {
            r = gameObject.AddComponent<Rigidbody2D>();
        }

        // 스페이스 바 눌린 시간에 비례한 초기 속도로 이동
        r.velocity = new Vector2(10 * bulletSpeed, 5 * bulletSpeed);
        r.gravityScale = 15.0f;
    }
}
