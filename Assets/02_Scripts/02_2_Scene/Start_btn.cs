using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_btn : MonoBehaviour
{
    //시작 화면에서 'Touch to Start'를 누를 경우 로딩화면 이후 메인 화면을 띄울 수 있도록 값을 지정하는 함수입니다.
    GameObject manager;

    void Start()
    {
        manager = GameObject.Find("GameManager");
    }
    public void Click()
    {
        manager.GetComponent<GameManager>().nextScene = "Main";
        SceneManager.LoadScene("Loading");
    }
}
