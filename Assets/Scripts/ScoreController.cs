using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text text_bestScore;
    public Text text_currentScore;

    public int currentScore;
    int bestScore;

    private void Start()
    {
        bestScore = PlayerPrefs.GetInt("BestScore");
        text_bestScore.text = "" + bestScore;
    }
    private void Update()
    {
        if(currentScore > bestScore) {
            bestScore = currentScore;
            PlayerPrefs.SetInt("BestScore", bestScore);
            text_bestScore.text = "" + bestScore;
        }
    }
    public void PlusScore() {
        currentScore++;
        text_currentScore.text = "" + currentScore;
    }
}
