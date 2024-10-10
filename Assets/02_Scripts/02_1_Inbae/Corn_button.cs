using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Corn_button : MonoBehaviour
{
    public void Click()
    {
        SceneManager.LoadScene("SampleScene 1");
    }
}