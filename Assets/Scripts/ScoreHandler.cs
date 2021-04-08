using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreHandler : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    private int score = 0;
    private const int MIN_SCORE = 0;
    private const int SCORE_INCREMENT = 1;
    private const string SCORE_STR = "SCORE: ";


    private void Start() {
        scoreText.SetText(SCORE_STR + MIN_SCORE.ToString());
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag.Equals("Enemy")) {
            HandleScore();
        }
    }


    private void HandleScore() {
        score += SCORE_INCREMENT;
        scoreText.SetText(SCORE_STR + score.ToString());
    }
}
