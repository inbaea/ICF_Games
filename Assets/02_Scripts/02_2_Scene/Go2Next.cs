using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Go2Next : MonoBehaviour
{
    //로딩 화면 이후 어느 화면을 띄워야 할지 결정하는 스크립트입니다.
    GameObject manager;

    void Start()
    {
        StartCoroutine(GoNext());
        manager = GameObject.Find("GameManager");
    }

    IEnumerator GoNext()
    {
        yield return new WaitForSeconds(10.5f);
        if (manager.GetComponent<GameManager>().nextScene == "Main")
        {
            SceneManager.LoadScene("Main");
        }

        if (manager.GetComponent<GameManager>().nextScene == "Dictionary")
        {
            SceneManager.LoadScene("Dictionary");
        }
    }
}
