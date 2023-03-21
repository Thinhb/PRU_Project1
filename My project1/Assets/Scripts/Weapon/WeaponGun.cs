using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponGun : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletPos;
    public float timerdelay=0.5f;
    private float timer;
    private GameObject enemy;

    void Start()
    {
       
    }
    void Update()
    {
        enemy = GameObject.FindGameObjectWithTag("enemy");
        timer += Time.deltaTime;

        float distance = Vector2.Distance(transform.position, enemy.transform.position);
        if(distance < 30)
        {
            timer += Time.deltaTime;
            if (timer > timerdelay)
            {
                timer = 0;
                shoot();
            }
        }
        
    }
    void shoot()
    {
        Instantiate(bullet, bulletPos.position, Quaternion.identity);
    }
}
