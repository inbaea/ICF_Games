using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.EventSystems;

public class CardFlip1 : MonoBehaviour, IPointerClickHandler
{
    public Sprite front;
    public Sprite back;
    public Image thisImage;
    public GameObject match;
    public bool isFlipped = true;

    private void Start()
    {
        thisImage = GetComponent<Image>();
        back = GameObject.Find("Front").GetComponent<Image>().sprite;
        front = GameObject.Find("Back1_image").GetComponent<Image>().sprite;
        match = GameObject.Find("MatchFind");
    }
    public void FlipCard()
    { // 카드 뒤집는 메서드
        Vector3 originalScale = transform.localScale; // 맨 처음 가지고 있던 x,y,z 값을 불러와 저장한다.
        Vector3 targetScale = new Vector3(0f, originalScale.y, originalScale.z); // x값을 0으로 변경하고자 하는 스케일 값

        transform.DOScale(targetScale, 0.2f).OnComplete(() =>
        {
            isFlipped = !isFlipped; // 카드의 상태를 변경

            if (isFlipped)
            {
                thisImage.sprite = front; // 현재 카드 생태를 앞면의 동물카드로 변경
            }
            else
            {
                thisImage.sprite = back; // 현재 카드 생태를 뒷면의 배경카드로 변경
            }

            transform.DOScale(originalScale, 0.2f);
        }); // 현재의 스케일 값을 0.2초동안 targetScale로 값을 변경한다.
    }

    public IEnumerator slowFlipCard()
    {
        yield return new WaitForSeconds(1.0f);

        Vector3 originalScale = transform.localScale; // 맨 처음 가지고 있던 x,y,z 값을 불러와 저장한다.
        Vector3 targetScale = new Vector3(0f, originalScale.y, originalScale.z); // x값을 0으로 변경하고자 하는 스케일 값

        transform.DOScale(targetScale, 0.2f).OnComplete(() =>
        {
            isFlipped = !isFlipped; // 카드의 상태를 변경

            if (isFlipped)
            {
                thisImage.sprite = front; // 현재 카드 생태를 앞면의 동물카드로 변경
            }
            else
            {
                thisImage.sprite = back; // 현재 카드 생태를 뒷면의 배경카드로 변경
            }

            transform.DOScale(originalScale, 0.2f);
        }); // 현재의 스케일 값을 0.2초동안 targetScale로 값을 변경한다.
    }

    public IEnumerator destroythisOB()
    {
        yield return new WaitForSeconds(1.0f);

        gameObject.SetActive(false);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        FlipCard();
        if (match.GetComponent<Matching>().imageSet[0] == null)
            match.GetComponent<Matching>().imageSet[0] = gameObject;
        else match.GetComponent<Matching>().imageSet[1] = gameObject;
    }

    public void slowflip()
    {
        StartCoroutine(slowFlipCard());
    }
    public void destroythis()
    {
        StartCoroutine(destroythisOB());
    }
}
