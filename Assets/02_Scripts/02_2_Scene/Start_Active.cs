using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Active : MonoBehaviour
{
    //���� ���� �� 5�� ���� ������ ������ ������ �� ������ ������ ��ũ��Ʈ�Դϴ�.
    public GameObject pannel;
    void Start()
    {
        StartCoroutine(activePannel());
    }

    public IEnumerator activePannel()
    {
        yield return new WaitForSeconds(5.0f);

        pannel.SetActive(true);
    }
}
