using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Fade2 : MonoBehaviour
{
    public Image pannel;
    float time = 0f;
    float F_time = 1f;

    void Start()
    {
        StartCoroutine(Fade_flow());
    }

    IEnumerator Fade_flow()
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
        yield return new WaitForSeconds(0.5f);

        pannel.gameObject.SetActive(false);
        yield return null;
    }
}
