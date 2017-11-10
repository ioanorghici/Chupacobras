using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour {

    public float speed = 5f;
    private Transform target;
    private Animator ani;
    public int hp = 100;
    public int dmg = 10;
    public float atkspeed = 2f;
    private float nextatk;
    public float range;
    public float angle = 0f;
    public float lower = 0f;
    public float translate = 0f;
    private bool destroy = false;

    // Use this for initialization
    void Start()
    {
        transform.Rotate(Vector3.up * angle);
        transform.Translate(Vector3.up * lower);
        transform.Translate(Vector3.right * translate);
        nextatk = atkspeed;
        ani = GetComponent<Animator>();
        ani.enabled = true;
        target = Spawner.destination;
    }

    // Update is called once per frame
    void Update()
    {
        nextatk -= Time.deltaTime ;
        Component enemyObj;
        if (target == null)
            return;
        enemyObj = transform.parent.parent.parent.GetChild(0);
        foreach (Transform enemy in enemyObj.GetComponentInChildren<Transform>())
        {
            if (!enemy.name.Contains("Waypoint") && Vector3.Distance(transform.position, enemy.position) <= 4f + range)
            {
                enemy.GetComponent<Enemy>().damage(dmg);
                return;
            }
        }
        if(nextatk <= 0)
        {
            nextatk = atkspeed;
        }
        
        target.Translate(Vector3.right * -translate);
        Vector3 dir = target.position - transform.position;

        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
        if (Vector3.Distance(transform.position, target.position) <= 0.5f + range)
        {
            destroy = true;
        }
        target.Translate(Vector3.right * translate);
        if (destroy)
            Destroy(gameObject);
    }
    public void damage(int damage)
    {
    }
}
