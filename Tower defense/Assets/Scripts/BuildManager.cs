using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour {

    public GameObject karenPrefab;
    public GameObject vincentPrefab;
    public GameObject spencerPrefab;
    public GameObject[] enemies;
    private GameObject toBuild;
    public static float defaultTimer = 10f;
    public static float remainingTime = 1f;
    public static bool shouldSpawn = false;
    public static int index = 0;

    public static BuildManager instance;

    void Start()
    {
        if (instance != null)
            return;
        instance = this;
    }

    void Update()
    {
        remainingTime -= Time.deltaTime;
        if(remainingTime <= 0)
        {
            remainingTime = defaultTimer;
            shouldSpawn = true;
            index = (int)Random.Range(1, 8);
        }
    }

    public GameObject getToBuild()
    {
        return toBuild;
    }
    public void SetBuild(GameObject build)
    {
        toBuild = build;
    }
}
