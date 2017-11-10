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
        BuildManager.type = 1;
        buildManager.SetBuild(buildManager.karenPrefab);
    }
    public void PurchaseVincent()
    {
        BuildManager.type = 2;
        buildManager.SetBuild(buildManager.vincentPrefab);
    }
    public void PurchaseSpencer()
    {
        BuildManager.type = 3;
        buildManager.SetBuild(buildManager.spencerPrefab);
    }
    public void PurchaseBlade()
    {
        BuildManager.type = 4;
        buildManager.SetBuild(buildManager.bladePrefab);
    }

}
