using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;
public class StartText : MonoBehaviour
{
    public LoopType looptype;
    public TextMeshProUGUI text;

    private void Start()
    {
        text.DOFade(0.0f, 1).SetLoops(-1, looptype);
    }
}
