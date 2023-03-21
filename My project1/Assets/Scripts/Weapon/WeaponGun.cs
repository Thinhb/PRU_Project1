using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponGun : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
    private float nextActionTime = 1f;
    public float period = 0.1f;
    public float updateInterval = 0.5F;
  

    void Update()
    {
        
        if (Time.time > nextActionTime)
        {
            nextActionTime += period;
            autoShoot();
        }
       
    }
    //void Shoot()
    //{
    //    if (Input.GetKeyDown(KeyCode.Z))
    //    {

    //        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
    //        bullet.GetComponent<Rigidbody2D>().AddForce(bulletSpawnPoint.right * bulletSpeed, ForceMode2D.Impulse);

    //    }

    //}
    void autoShoot()
    {
        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        bullet.GetComponent<Rigidbody2D>().AddForce(bulletSpawnPoint.right * bulletSpeed, ForceMode2D.Impulse);
    }

}
