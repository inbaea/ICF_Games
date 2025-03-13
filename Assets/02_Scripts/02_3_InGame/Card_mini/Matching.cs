using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Matching : MonoBehaviour
{
    //카드 미니게임에서 클릭한 두 카드가 일치하는지 확인하고 해당 카드를 없앨지 다시 뒤집을지 결정하는 스크립트입니다.
    //카드의 이름으로 비교하는 방식입니다.
    public GameObject[] imageSet;
    public int i;

    void Update()
    {
        if (imageSet[1] != null)
        {
            if(imageSet[0].name.Equals(imageSet[1].name))
            {
                for (i = 0;i<2;i++)
                {
                    if (imageSet[0].name.Equals("Back1"))
                    {
                        imageSet[0].GetComponent<CardFlip1>().destroythis();
                        imageSet[1].GetComponent<CardFlip1>().destroythis();
                    }
                    if (imageSet[0].name.Equals("Back2"))
                    {
                        imageSet[0].GetComponent<CardFlip2>().destroythis();
                        imageSet[1].GetComponent<CardFlip2>().destroythis();
                    }
                }

                imageSet = new GameObject[2];
            }
            else
            {
                if (imageSet[0].name.Equals("Back1"))
                    imageSet[0].GetComponent<CardFlip1>().slowflip();
                if (imageSet[0].name.Equals("Back2"))
                    imageSet[0].GetComponent<CardFlip2>().slowflip();
                if (imageSet[1].name.Equals("Back1"))
                    imageSet[1].GetComponent<CardFlip1>().slowflip();
                if (imageSet[1].name.Equals("Back2"))
                    imageSet[1].GetComponent<CardFlip2>().slowflip();

                imageSet = new GameObject[2];
            }
        }
    }
}
