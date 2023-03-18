using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponGun : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 15;


    private void Start()
    {


    }
    void Update()
    {
        autoShoot();
    }
    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {

            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody2D>().AddForce(bulletSpawnPoint.right * bulletSpeed, ForceMode2D.Impulse);

        }

    }
    void autoShoot()
    {
        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        bullet.GetComponent<Rigidbody2D>().AddForce(bulletSpawnPoint.right * bulletSpeed, ForceMode2D.Impulse);
    }
}
