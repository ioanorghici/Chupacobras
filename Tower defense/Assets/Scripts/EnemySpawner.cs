using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Color hoverColor;
    public int index;
    public static Transform destination;
    BuildManager buildManager;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (buildManager == null)
            buildManager = BuildManager.instance;
        if (BuildManager.shouldSpawn == true && BuildManager.index == index)
        {
            BuildManager.shouldSpawn = false;
            GameObject personToBuild = buildManager.enemies[(int)Random.Range(0,3)];
            destination = transform.parent.GetChild(1).GetChild(0).transform;
            var newObject = Instantiate(personToBuild, transform.position, transform.rotation);
            newObject.transform.parent = gameObject.transform;
        }
    }
}
