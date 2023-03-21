using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenRightMap : MonoBehaviour
{
    public GameObject map;
    bool check = true;
    public float location;
    // Start is called before the first frame update
    void Start()
    {
        
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
            bool checkGen = RightMap.GetComponent<GenMapCheck>().checkGen;
            if (check && checkGen)
            {
                GameObject LeftMap = GameObject.FindGameObjectWithTag("MapLeft");
                LeftMap.GetComponent<GenMapCheck>().checkGen = false;
                var newmap = Instantiate(map, map.transform.position + new Vector3(location, 0, 0), Quaternion.identity);
                Debug.Log("spawnMap");
                check = false;
                //LeftMap.GetComponent<GenMapCheck>().checkGen = true;
            }
        }
    }
}
