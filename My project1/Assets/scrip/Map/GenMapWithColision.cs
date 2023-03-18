using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GenMapWithColision : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject map;
    bool check = true;
    public float location;
    GenMapCheck mapcheck;
    MapInfinity mapinfinity;
    void Start()
    {
        mapcheck= FindObjectOfType<GenMapCheck>();
        mapinfinity= FindObjectOfType<MapInfinity>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject RightMap = GameObject.FindGameObjectWithTag("MapRight");            
            if (check)
            {
                
                GameObject LeftMap = GameObject.FindGameObjectWithTag("MapLeft");
                LeftMap.GetComponent<GenMapCheck>().checkGen = false;
                var newmap= Instantiate(map, map.transform.position + new Vector3(location, 0, 0), Quaternion.identity);
                Debug.Log("spawnMap");
                check = false;
                LeftMap.GetComponent<GenMapCheck>().checkGen = true;                
            }
        }
    }
}
