using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed=15;
    public float magazine=15;
    public float coolDown = 10f;
    public CanvasNumberBullet numberBullet;

    private void Start()
    {
        numberBullet = FindObjectOfType<CanvasNumberBullet>();
        numberBullet.NummbetBullet("Bullet:" + magazine);
  
    }
    void Update()
    {
        StartCoroutine(Shoot());
    }
    IEnumerator Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Z) && magazine>0)
        {
            
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody2D>().AddForce(bulletSpawnPoint.right * bulletSpeed, ForceMode2D.Impulse);
            magazine--;
            numberBullet.NummbetBullet("Bullet:" + magazine);
            if (magazine == 0)
            {
                yield return new WaitForSeconds(coolDown);
                magazine = 15;
                numberBullet.NummbetBullet("Bullet:" + magazine);
            }
            
        }
       
    }
}
