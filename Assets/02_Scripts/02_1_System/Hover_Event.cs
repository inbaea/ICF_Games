using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hover_Event : MonoBehaviour
{
    //메인 화면에서 A마을을 지정할 때에 hovering 이벤트가 발생해 회색빛을 띄는 투명한 물체를 띄우는 스크립트입니다.
    //color.a의 값을 수정해 투명도를 조절할 수 있지만, 해당 숫자는 최솟값이 0, 최댓값이 1이며, 1은 알파값 255를 의미합니다.
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