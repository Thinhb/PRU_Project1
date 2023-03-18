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
    private double lastInterval;
    private int frames;
    private float fps;
    void Start()
    {
        lastInterval = Time.realtimeSinceStartup;
        frames = 0;
    }

    void Update()
    {
        
        if (Time.time > nextActionTime)
        {
            nextActionTime += period;
            autoShoot();
        }
        ++frames;
        float timeNow = Time.realtimeSinceStartup;
        if (timeNow > lastInterval + updateInterval)
        {
            fps = (float)(frames / (timeNow - lastInterval));
            frames = 0;
            lastInterval = timeNow;

        } 
        Debug.Log(fps.ToString("f2"));
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
