using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_btn : MonoBehaviour
{
    //���� ȭ�鿡�� 'Touch to Start'�� ���� ��� �ε�ȭ�� ���� ���� ȭ���� ��� �� �ֵ��� ���� �����ϴ� �Լ��Դϴ�.
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
