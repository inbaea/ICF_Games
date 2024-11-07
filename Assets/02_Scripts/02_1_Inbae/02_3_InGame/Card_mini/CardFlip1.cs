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

    public IEnumerator slowFlipCard()
    {
        yield return new WaitForSeconds(1.0f);

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
