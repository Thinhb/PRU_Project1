using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    bool check = true;
    float xDirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        xDirection = Input.GetAxisRaw("Horizontal");
        if (xDirection>0 && !check)
        {
            flip();
        }
        if (xDirection< 0 && check)
        {
            flip();
        }
    }
    void flip()
    {
        transform.Rotate(0, -180,0);    
        check =!check;
    }
}
