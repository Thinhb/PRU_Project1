using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    public AIPath aiPath;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (aiPath.desiredVelocity.x >= 0.01f)
        {
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }
        else if (aiPath.desiredVelocity.x <= 0.01f)
        {
            transform.localScale = new Vector3(-0.5f, 0.5f, 0.5f);
        }
    }
}
