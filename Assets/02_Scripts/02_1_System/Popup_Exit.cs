using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup_Exit : MonoBehaviour
{
    //���� ȭ�鿡�� ������ Ŭ���� �� ���� �˾�â���� xǥ�� �������� ������ ���� �˾�â�� �ٽ� ȭ�� ������ �̵���Ű�� ��ũ��Ʈ�Դϴ�.
    public RectTransform buttonPos;

    public void Exit_Popup()
    {
        buttonPos.anchoredPosition = new Vector2(-2000, buttonPos.anchoredPosition.y);
    }
}
