using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public FloatingJoystick joystick;
    Vector2 move;
    [SerializeField]

    public GameObject bulletPrefab;
    public Transform gun2;
    public Transform gun1;
    private float timeCreate;

    public float bulletSpeed = 10f;
    private void Update()
    {
        move.x = joystick.Horizontal;
        move.y = joystick.Vertical;
    }
    void FixedUpdate()
    {
        Weapon();
        onClickBullet();
    }

    private void Weapon()
    {
        float horizontal = joystick.Horizontal;
        float vertical = joystick.Vertical;

        float angle = Mathf.Atan2(vertical, horizontal) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        if (move.x > 0)
        {
            //Sprite.flipY = false;
            //Sprite.flipX = false;
        }
        if (move.x < 0)
        {
            // Sprite.flipX = true;
            Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward) * Quaternion.AngleAxis(180, Vector3.forward);
            transform.rotation = rotation;
            transform.position = new Vector3(transform.position.x, transform.position.y, 180);
        }
    }

    private void onClickBullet()
    {
        timeCreate += Time.deltaTime;
        if (timeCreate >= 2 && (int)timeCreate % 2 == 0)
        {
            timeCreate = 0;
            if (move.x > 0)
            {

                Vector2 direction = (gun1.position - gun2.position).normalized;
                float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + gun2.localRotation.eulerAngles.z;


                GameObject bullet = Instantiate(bulletPrefab, gun2.position, Quaternion.identity);

                bullet.transform.rotation = Quaternion.Euler(0f, 0f, angle);


                Rigidbody2D bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
                bulletRigidbody.velocity = direction * bulletSpeed;

            }
            if (move.x < 0)
            {

                Vector2 direction = (gun2.position - gun1.position).normalized;
                float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + gun1.localRotation.eulerAngles.z;


                GameObject bullet = Instantiate(bulletPrefab, gun1.position, Quaternion.identity);

                bullet.transform.rotation = Quaternion.Euler(0f, 0f, angle);


                Rigidbody2D bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
                bulletRigidbody.velocity = direction * bulletSpeed;
            }
        }
    }
}