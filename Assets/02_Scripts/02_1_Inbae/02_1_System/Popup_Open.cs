using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup_Open : MonoBehaviour
{
    public RectTransform buttonPos;

    public void Open_Popup()
    {
        buttonPos.anchoredPosition = new Vector2(0, buttonPos.anchoredPosition.y);
    }
}
