using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup_Exit : MonoBehaviour
{
    //메인 화면에서 마을을 클릭한 후 생긴 팝업창에서 x표시 아이콘을 눌렀을 때에 팝업창을 다시 화면 밖으로 이동시키는 스크립트입니다.
    public RectTransform buttonPos;

    public void Exit_Popup()
    {
        buttonPos.anchoredPosition = new Vector2(-2000, buttonPos.anchoredPosition.y);
    }
}
