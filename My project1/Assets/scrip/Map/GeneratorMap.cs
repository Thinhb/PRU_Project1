using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorMap : MonoBehaviour
{
    public GameObject[] gameobject;
    // Start is called before the first frame update
    void Start()
    {
        int random = Random.Range(0, gameobject.Length);
        Instantiate(gameobject[random],transform.position,Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
