using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponGun : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletPos;

    private float timer;
    private GameObject enemy;

    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("enemy");
    }
    void Update()
    {
        timer += Time.deltaTime;

        float distance = Vector2.Distance(transform.position, enemy.transform.position);
        Debug.Log(distance);
        if(distance < 20)
        {
            timer += Time.deltaTime;
            if (timer > 2)
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
