using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class rotateEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    public AIPath aiPath;
    public float scale;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (aiPath.desiredVelocity.x >= 0.01f)
        {
            transform.localScale = new Vector3(scale, scale, scale);
        }
        else if (aiPath.desiredVelocity.x <= 0.01f)
        {
            transform.localScale = new Vector3(-scale, scale, scale);
        }
    }
}
