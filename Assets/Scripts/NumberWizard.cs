﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max = 1000;
    [SerializeField] int min = 1;
    [SerializeField] TextMeshProUGUI guessText;
    int guess = 500; 
    // Use this for initialization
    void Start()
    {
        StartGame();
    }
    void StartGame()
    {
        NextGuess();
    }
    public void OnPressHigher()
    {
        min = guess +1;
        NextGuess();
    }
    public void OnPressLower()
    {
        max = guess -1; 
        NextGuess();
    }

    void NextGuess()
    {
        //guess = (max + min) / 2;
        guess = Random.Range(min, max);
        guessText.text = guess.ToString();
    }
}
