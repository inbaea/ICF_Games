using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class StartText : MonoBehaviour
{
    public TMP_Text tmp;
    public TextMeshProUGUI tmp2;
    public GameObject maneger;

    void Start()
    {
        maneger = GameObject.Find("GameManager");
        if (maneger.GetComponent<GameManager>().date == 0)


        tmp.text = "원하는 텍스트 적어넣기";
        tmp2.text = "원하는 텍스트 적어넣기2";
    }
}
