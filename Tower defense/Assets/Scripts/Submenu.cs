using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Submenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.GetChild(1).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update () {

    }
    public void showSubmenu()
    {
        transform.GetChild(1).gameObject.SetActive(true);
    }
    public void hideSubmenu()
    {
        transform.GetChild(1).gameObject.SetActive(false);
    }
}
