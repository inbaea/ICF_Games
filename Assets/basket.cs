using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // 총알과 충돌 감지
        if (other.gameObject.CompareTag("bullet"))
        {
            // GameManager에서 점수 추가
            FindObjectOfType<GameManager>().AddScore(10);
            
            // 충돌한 총알 삭제
            Destroy(other.gameObject);
        }
    }
}
