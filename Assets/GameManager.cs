using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score = 0; // 점수 변수
    public TextMeshProUGUI scoreText; // TMP 텍스트 UI

    // 점수를 추가하는 메서드
    public void AddScore(int value)
    {
        score += value;
        UpdateScoreText();
    }

    // 점수 UI 업데이트
    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }
}
