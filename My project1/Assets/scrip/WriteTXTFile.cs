using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class WriteTXTFile : MonoBehaviour
{
    // Start is called before the first frame update
    string fileName,myPathFile;
    public Transform position;
    string[] positionString= new string[1];
    void Start()
    {
        fileName = "position.txt";
        myPathFile= Application.dataPath+"/"+fileName;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void write()
    {
        positionString[0] = position.position.x + " " + position.position.y;
        Debug.Log(positionString[0].ToString());
        File.WriteAllLines(myPathFile, positionString);
    }
}
