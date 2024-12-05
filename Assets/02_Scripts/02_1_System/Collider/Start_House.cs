using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Start_House : MonoBehaviour
{
    //게임 시작 화면에서 떨어지는 오브젝트의 콜라이더 충돌을 설정하는 스크립트입니다.
    public GameObject parent;

    void OnEnable()
    {
        GameObject[] otherObjects = GameObject.FindGameObjectsWithTag("House");

        parent = transform.parent.gameObject;

        for (int i = 0; i < otherObjects.Length; i++)
        {
            if (otherObjects[i].name == parent.name)
            {
                continue;
            }
            else
            {
                Physics2D.IgnoreCollision(otherObjects[i].GetComponent<Collider2D>(), GetComponent<Collider2D>());
            }
        }
    }
}
