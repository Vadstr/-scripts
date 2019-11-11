using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public static int scoreAmount;
    Text scoreText;
    public static int all;

    
    void Start()
    {
        scoreText = GetComponent<Text>();
        scoreAmount = 0;
        all = 0;
    }

    
    void Update()
    {
        scoreText.text = scoreAmount + "/" + all;
    }
}