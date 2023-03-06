using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 15;
    public float magazine = 15;
    public float coolDown = 10f;


    private void Start()
    {

    }
    void Update()
    {
        Shoot();
    }
    public void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {

            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody2D>().AddForce(bulletSpawnPoint.right * bulletSpeed, ForceMode2D.Impulse);


        }

    }
}