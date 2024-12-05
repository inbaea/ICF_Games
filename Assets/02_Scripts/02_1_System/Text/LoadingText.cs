using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LoadingText : MonoBehaviour
{
    //�ε� ȭ�鿡�� ��� ���ִ� ���ڸ� 1�ʸ��� ��ȯ��Ű�� ��ũ��Ʈ�Դϴ�.
    //WaitForSeconds()�� ������ ���ڰ� ���ϴ� �ð��� ������ �� �ֽ��ϴ�.
    int state = 1;
    public TMP_Text tmp;
    void Start()
    {
        StartCoroutine(LoadingText_a());
    }

    IEnumerator LoadingText_a()
    {
        if (state == 1)
        {
            tmp.text = "�� �� �� .";
            state = 2;
            yield return new WaitForSeconds(1f);
        }

        else if (state == 2)
        {
            tmp.text = "�� �� �� . .";
            state = 3;
            yield return new WaitForSeconds(1f);
        }

        else if (state == 3)
        {
            tmp.text = "�� �� �� . . .";
            state = 1;
            yield return new WaitForSeconds(1f);
        }
        StartCoroutine(LoadingText_a());

        yield return null;
    }
}
