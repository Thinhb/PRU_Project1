using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillManager : MonoBehaviour
{
    public int priceHealth = 50;
    public Text text;
    public HealthHitCharacter healthHitCharacter;

    public void Buyhealth()
    {
        if( 0 < healthHitCharacter.hitpoint && healthHitCharacter.hitpoint< healthHitCharacter.Maxhealth)
        {
            healthHitCharacter.hitpoint += 5;
        } else if(healthHitCharacter.hitpoint == healthHitCharacter.Maxhealth)
        {
            healthHitCharacter.hitpoint += 0;
            text.text = "Full of bool";
        }
    }
    public void BuySeep()
    {

    }
    public void Buy()
    {

    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
