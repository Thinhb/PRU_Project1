using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthHitCharacter : MonoBehaviour
{
    // Start is called before the first frame update
    public float hitpoint;
    public float Maxhealth=15;
    public HealthCharacter healthCharacter;
    void Start()
    {
        hitpoint= Maxhealth;
        healthCharacter.setHealth(hitpoint, Maxhealth);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Enemy"))
        {
            hitpoint--;
            healthCharacter.setHealth(hitpoint, Maxhealth);
        }
        if (hitpoint <= 0)
        {
            Destroy(gameObject);
        }
    }
}
