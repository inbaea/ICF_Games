using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;

public class Hover : MonoBehaviour, IPointerEnterHandler
{
    //클릭 미니게임에서 마우스가 물체 위에 올라왔을 때에 hovering효과를 줄 수 있는 스크립트입니다.
    public Image thisImage;
    public GameObject selectedImage;
    
    void Start()
    {
        thisImage = GetComponent<Image>();
    }

    //Do this when the cursor enters the rect area of this selectable UI object.
    public void OnPointerEnter(PointerEventData eventData)
    {
        thisImage.sprite = selectedImage.GetComponent<Image>().sprite;
    }
}
