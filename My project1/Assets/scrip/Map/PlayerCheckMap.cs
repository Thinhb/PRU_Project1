using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckMap : MonoBehaviour
{
    // Start is called before the first frame update
    GenMapCheck mapcheck;
    public string direction;
    void Start()
    {
        mapcheck= FindObjectOfType<GenMapCheck>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("MapLeft"))
        {
            direction = "left";
        }
        if (collision.gameObject.CompareTag("MapRight"))
        {
            direction = "right";
        }
    }
}
