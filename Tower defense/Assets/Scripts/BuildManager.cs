using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour {

    public GameObject karenPrefab;
    public GameObject vincentPrefab;
    public GameObject bladePrefab;
    public GameObject spencerPrefab;
    public GameObject[] enemies;
    private GameObject toBuild;
    public static float defaultTimer = 10f;
    public static float remainingTime = 1f;
    public static bool shouldSpawn = false;
    public static int index = 0;
    public static int money = 100;
    public static int score = 0;
    public static bool gameOver = false;
    public static float gameTime = 1.01f;

    private float moneyDefaultTimer = 1f;
    private float moneyTimer = 1f;

    public static int type = 0;
    public AudioSource audio;

    public static BuildManager instance;

    void Start()
    {
        if (instance != null)
            return;
        instance = this;
        audio.Play();
    }

    void Update()
    {
        gameTime += Time.deltaTime;
        remainingTime -= Time.deltaTime;
        moneyTimer -= Time.deltaTime;
        if (Mathf.Floor(gameTime) % 10 == 0 && defaultTimer >= 1)
        {
            defaultTimer -= defaultTimer / 8;
            gameTime += 1;
        }
        if(moneyTimer <= 0)
        {
            moneyTimer = moneyDefaultTimer;
            money += 25;
            score += 25;
        }
        if(remainingTime <= 0)
        {
            remainingTime = defaultTimer;
            shouldSpawn = true;
            index = (int)Random.Range(1, 8);
        }
    }

    public GameObject getToBuild()
    {
        if (type == 0)
            return null;
        if (type == 1)
            if (money >= 100)
                money -= 100;
            else
                return null;
        if (type == 2)
            if (money >= 200)
                money -= 200;
            else
                return null;
        if (type == 3)
            if (money >= 300)
                money -= 300;
            else
                return null;
        if (type == 4)
            if (money >= 150)
                money -= 150;
            else
                return null;
        return toBuild;
    }
    public void SetBuild(GameObject build)
    {
        toBuild = build;
    }
}
