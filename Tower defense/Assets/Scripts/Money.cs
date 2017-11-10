using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;


public class Money : MonoBehaviour {
    public Text scoreText;
    public int score = 0;
	// Use this for initialization
	void Start () {
        scoreText.text = "Money: " + BuildManager.money.ToString()+ "€";
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "Money: " + BuildManager.money.ToString() + "€\nTime: " + Math.Round(BuildManager.gameTime, 2);
    }
}
