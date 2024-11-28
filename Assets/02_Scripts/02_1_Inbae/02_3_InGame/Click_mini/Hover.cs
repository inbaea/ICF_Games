using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;

public class Hover : MonoBehaviour, IPointerEnterHandler
{
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
