using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverOut : MonoBehaviour, IPointerExitHandler
{
    //클릭 미니게임에서 마우스가 물체 위에 올라왔을 때에 hovering효과를 해제하는 스크립트입니다.
    public Image thisImage;
    public GameObject unselectedImage;

    void Start()
    {
        thisImage = GetComponent<Image>();
    }

    //Do this when the cursor exits the rect area of this selectable UI object.
    public void OnPointerExit(PointerEventData eventData)
    {
        thisImage.sprite = unselectedImage.GetComponent<Image>().sprite;
    }
}
