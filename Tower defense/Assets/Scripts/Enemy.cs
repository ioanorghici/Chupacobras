using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float speed = 5f;
    private Transform target;
    private Animator ani;
    public int hp = 100;
    public int dmg = 10;
    public float atkspeed = 2f;
    private float nextatk;
    public float range;

    // Use this for initialization
    void Start ()
    {
        nextatk = atkspeed;
        ani = GetComponent<Animator>();
        ani.enabled = true;
        target = EnemySpawner.destination;
    }

    // Update is called once per frame
    void Update ()
    {
        Component enemyObj;
        if (target == null)
            return;
        enemyObj = transform.parent.parent.GetChild(1).GetChild(0);
        foreach (Transform enemy in enemyObj.GetComponentInChildren<Transform>())
        {
            if (!enemy.name.Contains("Waypoint") && Vector3.Distance(transform.position, enemy.position) <= 4f + range)
            {
                ani.SetBool("isFighting", true);
                ani.SetBool("isWalking", false);
                nextatk -= Time.deltaTime;
                if (nextatk <= 0)
                {
                    nextatk = atkspeed;
                    enemy.GetComponent<Friendly>().damage(dmg);
                }
                return;
            }
        }
        Vector3 dir = target.position - transform.position;
        if (Vector3.Distance(transform.position, target.position) <= 0.5f + range)
        {
            ani.SetBool("isFighting", true);
            ani.SetBool("isWalking", false);
            return;
        }
        ani.SetBool("isFighting", false);
        ani.SetBool("isWalking", true);
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
   }
    public void damage(int damage)
    {
        hp -= damage;
        if (hp <= 0)
            Destroy(gameObject);
    }
}
