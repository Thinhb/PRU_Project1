using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healOfEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    int health = 3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("bullet"))
        {
            health--;   
           
        }
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
