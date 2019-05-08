using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text ScoreText;
    private int Score;

    void Start()
    {
        ScoreInitialize();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = Score.ToString();
        ScoreText.text = "Score"+Score;
        
    }
    void ScoreInitialize()
    {
        Score = 0;

    }
    public void AddScore(int scoreValue)
    {
        Score += scoreValue;
        ScoreText.text = "Score" + Score;
    }
}
