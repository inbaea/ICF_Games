using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Go2Dict : MonoBehaviour
{
    //����ȭ�鿡�� �ε�ȭ�� ���� ���� ȭ������ �̵��� �� �ֵ��� ���� �����ϴ� ��ũ��Ʈ�Դϴ�.
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
