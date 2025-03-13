using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Go2Dict : MonoBehaviour
{
    //메인화면에서 로딩화면 이후 사전 화면으로 이동할 수 있도록 값을 설정하는 스크립트입니다.
    GameObject manager;

    void Start()
    {
        manager = GameObject.Find("GameManager");
    }
    public void Click()
    {
        manager.GetComponent<GameManager>().nextScene = "Dictionary";
        SceneManager.LoadScene("Loading");
    }
}
