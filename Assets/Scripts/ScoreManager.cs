using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    [SerializeField] private TextMeshProUGUI scoreText;       
    [SerializeField] private TextMeshProUGUI highScoreText;   

    private int score;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }    
    }
    private void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
        highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        UpdateHighScore();
    }

    private void UpdateHighScore()
    {
        if (score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScoreText.text = score.ToString();
        } 
    }

    public void UpdateScore()
    {
        score++;
        scoreText.text = score.ToString();
        UpdateHighScore();
    }
}
