using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthCharacter : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider;
    public Vector3 Offset;
    void Update()
    {
        slider.transform.position=Camera.main.WorldToScreenPoint(transform.parent.position+Offset);
    }
    public void setHealth(float health,float maxHealth)
    {
        slider.gameObject.SetActive(health < maxHealth);
        slider.value = health;
        slider.maxValue= maxHealth; 
    }
}
