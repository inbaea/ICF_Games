using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_btn : MonoBehaviour
{
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
