using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private GameObject enemy;
    private Rigidbody2D rb;
    public float force;
    EnemyHealth healthEnemy;
    public int damage = 20;
    GameController coin;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        enemy = GameObject.FindGameObjectWithTag("enemy");
        healthEnemy=FindObjectOfType<EnemyHealth>();
        Vector3 direction = enemy.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;
        float rot = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot);
        coin=FindObjectOfType<GameController>();
    }
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        /*if (collision.gameObject.CompareTag("enemy"))
        {
            healthEnemy.getDamage(damage);
            
            Debug.Log(healthEnemy.health);
            if (healthEnemy.health <= 0)
            {
                Destroy(collision.gameObject);
                coin.incrementSscore();
            }
            Destroy(gameObject);
        }*/
    }
}
