using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Start_House : MonoBehaviour
{
    //���� ���� ȭ�鿡�� �������� ������Ʈ�� �ݶ��̴� �浹�� �����ϴ� ��ũ��Ʈ�Դϴ�.
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
