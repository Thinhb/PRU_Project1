using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenLeftMap : MonoBehaviour
{
    // Start is called before the first frame update
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
            GameObject LeftMap = GameObject.FindGameObjectWithTag("MapLeft");
            bool checkGen = LeftMap.GetComponent<GenMapCheck>().checkGen;
            if (check && checkGen)
            {
                GameObject RightMap = GameObject.FindGameObjectWithTag("MapRight");
                RightMap.GetComponent<GenMapCheck>().checkGen = false;
                var newmap = Instantiate(map, map.transform.position + new Vector3(location, 0, 0), Quaternion.identity);
                Debug.Log("spawnMap");
                check = false;
                RightMap.GetComponent<GenMapCheck>().checkGen = true;
            }
        }
    }
}
