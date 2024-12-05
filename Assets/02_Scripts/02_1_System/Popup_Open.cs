using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup_Open : MonoBehaviour
{
    //메인 화면에서 마을을 클릭할 때 마다 팝업창을 띄우도록 만드는 스크립트입니다.
    //팝업창은 UI캔버스 밖에서 제작한 후, 각 마을마다 RectTransform buttonPos를 알맞게 설정하면 각기 다른 팝업창이 나타날 것 입니다.
    public RectTransform buttonPos;

    public void Open_Popup()
    {
        buttonPos.anchoredPosition = new Vector2(0, buttonPos.anchoredPosition.y);
    }
}
