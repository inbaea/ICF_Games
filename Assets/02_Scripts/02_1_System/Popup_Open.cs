using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup_Open : MonoBehaviour
{
    //���� ȭ�鿡�� ������ Ŭ���� �� ���� �˾�â�� ��쵵�� ����� ��ũ��Ʈ�Դϴ�.
    //�˾�â�� UIĵ���� �ۿ��� ������ ��, �� �������� RectTransform buttonPos�� �˸°� �����ϸ� ���� �ٸ� �˾�â�� ��Ÿ�� �� �Դϴ�.
    public RectTransform buttonPos;

    public void Open_Popup()
    {
        buttonPos.anchoredPosition = new Vector2(0, buttonPos.anchoredPosition.y);
    }
}
