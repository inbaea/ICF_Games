using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tank : MonoBehaviour
{
    public float deg;
    public float turrentSpeed;
    public GameObject turret; // 포탑 오브젝트
    public GameObject bullet; // 프리팹으로 만든 bullet을 할당할 변수
    private float holdTime = 0f; // 스페이스 바 누른 시간 기록용

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            deg += Time.deltaTime * turrentSpeed;
            float rad = deg * Mathf.Deg2Rad;
            turret.transform.localPosition = new Vector2(Mathf.Cos(rad) + 100, Mathf.Sin(rad) + 90);
            turret.transform.eulerAngles = new Vector3(0, 0, deg);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            deg -= Time.deltaTime * turrentSpeed;
            float rad = deg * Mathf.Deg2Rad;
            turret.transform.localPosition = new Vector2(Mathf.Cos(rad) + 100, Mathf.Sin(rad) + 90);
            turret.transform.eulerAngles = new Vector3(0, 0, deg);
        }

        // 스페이스 바를 누르고 있는 시간 측정
        if (Input.GetKey(KeyCode.Space))
        {
            holdTime += Time.deltaTime; // 누르고 있는 시간 증가
        }

        // 스페이스 바를 떼면 총알 생성 및 속도 설정
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("Space key released. Spawning bullet.");

            // holdTime을 0~2초로 제한
            holdTime = Mathf.Clamp(holdTime, 0, 2);

            // bulletSpeed 계산 (holdTime에 비례하여 최소 5, 최대 20)
            float bulletSpeed = Mathf.Lerp(5, 40, holdTime * 2); // 0초일 때 5, 2초일 때 20

            // 총알 프리팹 생성 및 속도 전달
            GameObject newBullet = Instantiate(bullet);
            newBullet.transform.SetParent(GameObject.Find("Canvas").transform, false);
            newBullet.transform.localPosition = new Vector3(-600,-200,0);
            newBullet.transform.rotation = turret.transform.rotation;

            // bulletSpeed 전달
            bullet bulletScript = newBullet.GetComponent<bullet>();
            bulletScript.bulletSpeed = bulletSpeed;

            // holdTime 초기화
            holdTime = 0f;
        }
    }
}
