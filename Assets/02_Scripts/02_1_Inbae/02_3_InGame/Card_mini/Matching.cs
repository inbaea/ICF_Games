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
            if(imageSet[0].name.Equals(imageSet[1].name))
            {
                Debug.Log("°°À½!");
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
