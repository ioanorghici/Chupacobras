using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VincentUpgrade : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void incSpeed()
    {
        if (BuildManager.money < 50)
            return;
        Friendly x = GameObject.Find("Dr_Cyrus").GetComponent<Friendly>();
        x.speed += 1;
        BuildManager.money -= 50;
    }
    public void incHealth()
    {
        if (BuildManager.money < 50)
            return;
        Friendly x = GameObject.Find("Dr_Cyrus").GetComponent<Friendly>();
        x.hp += 10;
        BuildManager.money -= 50;
    }
    public void incStrength()
    {
        if (BuildManager.money < 50)
            return;
        Friendly x = GameObject.Find("Dr_Cyrus").GetComponent<Friendly>();
        x.dmg += 5;
        BuildManager.money -= 50;
    }
}
