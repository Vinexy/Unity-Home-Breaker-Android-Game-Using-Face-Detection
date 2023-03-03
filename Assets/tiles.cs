﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class tiles : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI scoreText;
    private int totalTiles;
    private int counter;
    [SerializeField] int score;
    void Start()
    {
        totalTiles = transform.childCount;

    }

    // Update is called once per frame
    void Update()
    {

        counter = transform.childCount;
        if (counter == 0)
        {
            enabled = false;

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
        
            
        
        score = ((totalTiles - counter) * 10);
        scoreText.text =  score.ToString();
        
        
        
    }
}
