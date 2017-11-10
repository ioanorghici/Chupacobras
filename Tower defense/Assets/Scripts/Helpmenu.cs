using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helpmenu : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        transform.GetChild(0).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void showSubmenu()
    {
        transform.GetChild(0).gameObject.SetActive(true);
    }
    public void hideSubmenu()
    {
        transform.GetChild(0).gameObject.SetActive(false);
    }
}
