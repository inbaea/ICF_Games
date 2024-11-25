using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Go2Next : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject manager;

    void Start()
    {
        StartCoroutine(GoNext());
        manager = GameObject.Find("GameManager");
    }

    IEnumerator GoNext()
    {
        yield return new WaitForSeconds(10.5f);
        if (manager.GetComponent<GameManager>().nextScene == "Main")
        {
            SceneManager.LoadScene("Main");
        }

        if (manager.GetComponent<GameManager>().nextScene == "Dictionary")
        {
            SceneManager.LoadScene("Dictionary");
        }
    }
}
