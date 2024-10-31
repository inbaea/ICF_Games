using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.EventSystems;

public class CardFlip2 : MonoBehaviour, IPointerClickHandler
{
    public Sprite front;
    public Sprite back;
    public Image thisImage;
    public bool isFlipped = true;

    private void Start()
    {
        thisImage = GetComponent<Image>();
        back = GameObject.Find("Front").GetComponent<Image>().sprite;
        front = GameObject.Find("Back2").GetComponent<Image>().sprite;
    }
    public void FlipCard()
    { // ī�� ������ �޼���
        Vector3 originalScale = transform.localScale; // �� ó�� ������ �ִ� x,y,z ���� �ҷ��� �����Ѵ�.
        Vector3 targetScale = new Vector3(0f, originalScale.y, originalScale.z); // x���� 0���� �����ϰ��� �ϴ� ������ ��

        transform.DOScale(targetScale, 0.2f).OnComplete(() =>
        {
            isFlipped = !isFlipped; // ī���� ���¸� ����

            if (isFlipped)
            {
                thisImage.sprite = front; // ���� ī�� ���¸� �ո��� ����ī��� ����
            }
            else
            {
                thisImage.sprite = back; // ���� ī�� ���¸� �޸��� ���ī��� ����
            }

            transform.DOScale(originalScale, 0.2f);
        }); // ������ ������ ���� 0.2�ʵ��� targetScale�� ���� �����Ѵ�.
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        FlipCard();
    }
}
