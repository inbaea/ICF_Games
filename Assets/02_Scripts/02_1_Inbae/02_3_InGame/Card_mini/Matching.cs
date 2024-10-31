using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Matching : MonoBehaviour
{
    public GameObject[] imageSet;
    public int i;

    void Update()
    {
        if (imageSet[1] != null)
        {
            if(imageSet[0].GetComponent<Image>().sprite.Equals(imageSet[1].GetComponent<Image>().sprite))
            {
                Debug.Log("°°À½!");
                for (i = 0;i<2;i++)
                {
                    if (imageSet[0].name.Equals("Card"))
                    {
                        imageSet[0].GetComponent<CardFlip1>().FlipCard();
                    }
                    if (imageSet[0].name.Equals("Back1"))
                    {
                        imageSet[0].GetComponent<CardFlip1>().FlipCard();
                    }
                    if (imageSet[0].name.Equals("Back2"))
                    {
                        imageSet[0].GetComponent<CardFlip2>().FlipCard();
                    }
                }

                imageSet = new GameObject[2];
            }
        }
    }
}
