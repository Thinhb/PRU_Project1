using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class AIenemy : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform taget;
    public float speed = 200f;
    public float nextWayPointDistance = 3f;
    Path path;
    int currentWayPonit = 0;  
    bool reachedEndOfPath=false;
    Seeker seeker;
    Rigidbody2D rb;
    void Start()
    {
        seeker= GetComponent<Seeker>();
        rb= GetComponent<Rigidbody2D>();
        seeker.StartPath(rb.position,taget.position,onPathComplete);
    }
    void onPathComplete(Path p)
    {
        if (!p.error)
        {
            path= p;
            currentWayPonit = 0;
        }        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if (path == null)
        {
            return;
        }
        if (currentWayPonit >= path.vectorPath.Count)
        {
            reachedEndOfPath = true;
            return;
        }
        else
        {
            reachedEndOfPath = false;
        }
        Vector2 direction = ((Vector2)path.vectorPath[currentWayPonit] - rb.position).normalized;
        Vector2 force = direction * speed * Time.deltaTime;
        rb.AddForce(force);
        float distance = Vector2.Distance(rb.position, path.vectorPath[currentWayPonit]);
        if (distance < nextWayPointDistance)
        {
            currentWayPonit++;
        }
    }
}
