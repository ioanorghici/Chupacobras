using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public Color hoverColor;
    private Renderer rend;
    private Color startColor;
    private bool mouseOver = false;
    public static Transform destination;
    BuildManager buildManager;
    public int health = 100;

    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }
	
	// Update is called once per frame
	void Update () {
        if(buildManager == null)
            buildManager = BuildManager.instance;
    }
    void OnMouseDown()
    {
        if (mouseOver == false)
            return;
        GameObject personToBuild = buildManager.getToBuild();
        if (personToBuild == null)
            return;
        destination = transform.GetChild(0);
        var newObject = Instantiate(personToBuild, transform.position, transform.rotation);
        newObject.transform.parent = gameObject.transform;
    }
    void OnMouseEnter()
    {
        mouseOver = true;
        rend.material.color = hoverColor;
    }
    void OnMouseExit()
    {
        mouseOver = false;
        rend.material.color = startColor;
    }
    public void damage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
            BuildManager.gameOver = true;
        }
    }
}
