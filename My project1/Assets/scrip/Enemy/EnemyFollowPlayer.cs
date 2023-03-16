using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyFollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    Transform target;
    public int speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        follow();
    }
    void follow()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        transform.position = Vector2.MoveTowards(this.transform.position,target.transform.position,speed*Time.deltaTime);
       
    }
}
