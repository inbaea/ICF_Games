using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class ClickDestroy : MonoBehaviour, IPointerClickHandler
{
    //ȭ�鿡 �ִ� ��ü�� Ŭ���ϸ� �ش� ��ü�� ������ϴ�.
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        //Use this to tell when the user left-clicks on the Button
        if (pointerEventData.button == PointerEventData.InputButton.Left)
        {
            Destroy(gameObject);
        }
    }
}
