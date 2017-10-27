using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour {

    BuildManager buildManager;

    void Start()
    {
    }
    void Update()
    {
        if (buildManager == null)
            buildManager = BuildManager.instance;
    }

    public void PurchaseKaren()
    {
        buildManager.SetBuild(buildManager.karenPrefab);
    }
    public void PurchaseVincent()
    {
        buildManager.SetBuild(buildManager.vincentPrefab);
    }
    public void PurchaseSpencer()
    {
        buildManager.SetBuild(buildManager.spencerPrefab);
    }

}
