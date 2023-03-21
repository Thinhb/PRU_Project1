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
    void Start()
    {

    }
    void Update()
    {
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject RightMap = GameObject.FindGameObjectWithTag("MapRight");
            GameObject LeftMap = GameObject.FindGameObjectWithTag("MapLeft");
            Debug.Log(RightMap.GetComponent<GenMapCheck>().direction);
            RightMap.GetComponent<GenMapCheck>().checkGen = false;
            Debug.Log(RightMap.GetComponent<GenMapCheck>().checkGen);
            Debug.Log(LeftMap.GetComponent<GenMapCheck>().direction);
            Debug.Log(LeftMap.GetComponent<GenMapCheck>().checkGen);
            /*if (check)
            {                
                GameObject LeftMap1 = GameObject.FindGameObjectWithTag("MapLeft");
                LeftMap1.GetComponent<GenMapCheck>().checkGen = false;
                var newmap= Instantiate(map, map.transform.position + new Vector3(location, 0, 0), Quaternion.identity);
                Debug.Log("spawnMap");
                check = false;
                LeftMap1.GetComponent<GenMapCheck>().checkGen = true;
                
            }*/
        }
    }
}
