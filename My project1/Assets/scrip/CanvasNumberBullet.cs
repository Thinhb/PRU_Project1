using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasNumberBullet : MonoBehaviour
{
    // Start is called before the first frame update
    public Text numberBullet;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void NummbetBullet(string text)
    {
        if (numberBullet)
        {
            numberBullet.text = text;
        }
    }
       
    

}
