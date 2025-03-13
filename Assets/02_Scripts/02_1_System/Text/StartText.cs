using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;
public class StartText : MonoBehaviour
{
    //시작 화면에서 'Touch to Start'라는 글자에 깜빡임 효과를 넣을 수 있는 스크립트입니다.
    public LoopType looptype;
    public TextMeshProUGUI text;

    private void Start()
    {
        text.DOFade(0.0f, 1).SetLoops(-1, looptype);
    }
}
