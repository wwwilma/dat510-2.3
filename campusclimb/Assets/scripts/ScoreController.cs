using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreController : MonoBehaviour
{
    public static ScoreController instance;
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text bestText;

    int score = 0;
    int best = 0;
    public int scoreToAdd = 0;

    private void awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Compontent has initialzied");
        scoreText.text = "Score: 0";
        bestText.text = "Higest Score: 0";

    }

    public void AddScore(){
        scoreToAdd += 5;
        scoreText.text = "Score: " + scoreToAdd.ToString();

        if (score > best)
        {
            best = score;
            PlayerPrefs.SetInt("best", score);
        }
    }

}