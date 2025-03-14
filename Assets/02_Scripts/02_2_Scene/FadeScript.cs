using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeScript : MonoBehaviour
{
    //로딩 화면에서 잠시 어두운 화면이였다가 밝은 화면으로 전환되는 효과를 넣은 스크립트입니다.
    public Image pannel;
    float time = 0f;
    float F_time = 1f;

    private void Start()
    {
        StartCoroutine(Fadeflow());
    }

    IEnumerator Fadeflow()
    {
        pannel.gameObject.SetActive(true);
        time = 0f;
        Color alpha = pannel.color;

        yield return new WaitForSeconds(0.5f);

        while (alpha.a > 0f)
        {
            time += Time.deltaTime / F_time;
            alpha.a = Mathf.Lerp(1, 0, time);
            pannel.color = alpha;
            yield return null;
        }

        time = 0f;

        yield return new WaitForSeconds(7.5f);

        while (alpha.a < 1f)
        {
            time += Time.deltaTime / F_time;
            alpha.a = Mathf.Lerp(0, 1, time);
            pannel.color = alpha;
            yield return null;
        }

        yield return null;
    }
}
