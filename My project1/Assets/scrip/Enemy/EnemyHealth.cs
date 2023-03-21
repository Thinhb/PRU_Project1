using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public string enemyName;
    public int health;
    bullet damageBullet;
    GameController coin;
    // Start is called before the first frame update
    void Start()
    {
        coin = FindObjectOfType<GameController>();
        damageBullet =FindObjectOfType<bullet>();
        if (enemyName.Equals("flight"))
        {
            health = 15;
        }
        if (enemyName.Equals("slime"))
        {
            health = 20;
        }
        if (enemyName.Equals("mushroom"))
        {
            health = 50;
        }
       
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void getDamage(int damage)
    {
        health-=damage;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            int damage = collision.GetComponent<bullet>().damage;
            getDamage(damage);
            if (health <= 0)
            {
                Destroy(gameObject);
                coin.incrementSscore();
            }
            Destroy(collision.gameObject);
        }
    }
}
