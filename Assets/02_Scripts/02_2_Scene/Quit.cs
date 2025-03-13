using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    //게임을 종료하는 스크립트이지만, 사용되지는 않았습니다.
        public void ExitGame()  {
            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
            #else
                Application.Quit();
            #endif
    }
}
