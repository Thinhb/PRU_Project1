using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockTranform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        position.x = 0;
        transform.position = position;
    }
}