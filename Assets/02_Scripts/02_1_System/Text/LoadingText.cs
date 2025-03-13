using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LoadingText : MonoBehaviour
{
    //로딩 화면에서 가운데 떠있는 글자를 1초마다 변환시키는 스크립트입니다.
    //WaitForSeconds()를 수정해 글자가 변하는 시간을 조절할 수 있습니다.
    int state = 1;
    public TMP_Text tmp;
    void Start()
    {
        StartCoroutine(LoadingText_a());
    }

    IEnumerator LoadingText_a()
    {
        if (state == 1)
        {
            tmp.text = "로 딩 중 .";
            state = 2;
            yield return new WaitForSeconds(1f);
        }

        else if (state == 2)
        {
            tmp.text = "로 딩 중 . .";
            state = 3;
            yield return new WaitForSeconds(1f);
        }

        else if (state == 3)
        {
            tmp.text = "로 딩 중 . . .";
            state = 1;
            yield return new WaitForSeconds(1f);
        }
        StartCoroutine(LoadingText_a());

        yield return null;
    }
}
