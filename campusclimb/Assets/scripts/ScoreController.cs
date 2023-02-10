using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    [SerializeField]
    private Text _scoreText;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Compontent has initialzied");
        _scoreText.text = "Score: 0";
        
    }

}