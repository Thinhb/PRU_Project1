using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackByDamage : MonoBehaviour
{
    PlayerHealth healthPlayer;
    StatsPlayerAndEnemy Damage;
    public string enemyName;
    int damage;
    // Start is called before the first frame update
    void Start()
    {
        healthPlayer=FindObjectOfType<PlayerHealth>();
        Damage=FindObjectOfType<StatsPlayerAndEnemy>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (enemyName.Equals("flight"))
        {
            damage = Damage.GetComponent<StatsPlayerAndEnemy>().enemyFlightDamage;
        }
        if (enemyName.Equals("slime"))
        {
            damage = Damage.GetComponent<StatsPlayerAndEnemy>().enemySlimeDamage;
        }
        if (enemyName.Equals("mushroom"))
        {
            damage = Damage.GetComponent<StatsPlayerAndEnemy>().enemyMushRoomDamage;
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            healthPlayer.TakeDamage(damage);
        }
    }
}
