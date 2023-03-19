using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillManager : MonoBehaviour
{
    public int priceHealth = 50;
    public int priceSpeed = 100;
    public int priceSword = 50;
    public Text Displaytext;
    public HealthHitCharacter healthHitCharacter;
    public playerMove playermove;
    public UI ui;
    public GameController gameController;

    public void Buyhealth()
    {
        if( 0 < healthHitCharacter.hitpoint && healthHitCharacter.hitpoint< healthHitCharacter.Maxhealth && gameController.m_score >priceHealth)
        {
            healthHitCharacter.hitpoint += 5;
            gameController.m_score -= priceHealth;
            ui.textScore("Coin:" + gameController.m_score);
            Displaytext.text = "Successfully bought blood!";
        } else if(healthHitCharacter.hitpoint == healthHitCharacter.Maxhealth)
        {
            healthHitCharacter.hitpoint += 0;
            priceHealth = 0;
            ui.textScore("Coin:" + gameController.m_score);
            Displaytext.text = "Full of bool!";
        } else if(gameController.m_score < priceHealth)
        {
            Displaytext.text = "Not enough money!!!";
        }
    }
    public void BuySeep()
    {
      

    }
    public void BuySword()
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
