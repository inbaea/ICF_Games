using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class ClickDestroy : MonoBehaviour, IPointerClickHandler
{
    //화면에 있는 물체를 클릭하면 해당 물체가 사라집니다.
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        //Use this to tell when the user left-clicks on the Button
        if (pointerEventData.button == PointerEventData.InputButton.Left)
        {
            Destroy(gameObject);
        }
    }
}
