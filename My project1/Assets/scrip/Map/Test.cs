using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Tilemap tilemap = GameObject.Find("Grid").GetComponent<Tilemap>();
        int width = tilemap.size.x;
        int height = tilemap.size.y;

        Debug.Log("Tilemap width: " + width);
        Debug.Log("Tilemap height: " + height);
    }
}
