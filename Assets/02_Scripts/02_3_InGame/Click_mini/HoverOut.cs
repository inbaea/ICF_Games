using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverOut : MonoBehaviour, IPointerExitHandler
{
    //Ŭ�� �̴ϰ��ӿ��� ���콺�� ��ü ���� �ö���� ���� hoveringȿ���� �����ϴ� ��ũ��Ʈ�Դϴ�.
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
