using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Active : MonoBehaviour
{
    //게임 시작 후 5초 동안 강제로 게임을 시작할 수 없도록 설정한 스크립트입니다.
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
