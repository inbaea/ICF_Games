using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hover_Event : MonoBehaviour
{
    public Image hover_img;
    public Image no_hover_img;
    Image thisImg;
    Color color;

    // Start is called before the first frame update
    void Start()
    {
        thisImg = GetComponent<Image>();
        color = GetComponent<Image>().color;
    }

    public void ChangeButtonUI_In()
    {
        thisImg.sprite = hover_img.sprite;
        color.a = 0.3921568627450980392156862745098f;
        thisImg.color = color;
    }

    public void ChangeButtonUI_out()
    {
        thisImg.sprite = no_hover_img.sprite;
        color.a = 0f;
        thisImg.color = color;
    }
}