using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillManager : MonoBehaviour
{
    public int priceHealth = 50;
    public int priceSpeed = 10;
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
            StartCoroutine(DisplayTextForTime());
        }
        else if(healthHitCharacter.hitpoint == healthHitCharacter.Maxhealth)
        {
            healthHitCharacter.hitpoint += 0;
            priceHealth = 0;
            ui.textScore("Coin:" + gameController.m_score);
            Displaytext.text = "Full of bool!";
            StartCoroutine(DisplayTextForTime());
        } 
        else if(gameController.m_score < priceHealth)
        {
            Displaytext.text = "Not enough money!!!";
            StartCoroutine(DisplayTextForTime());
        }
    }
    public void BuySeep()
    {
        if (gameController.m_score > priceSpeed)
        {
          playermove.speedMove += 10;
          gameController.m_score -= priceSpeed;
          ui.textScore("Coin:" + gameController.m_score);
         Displaytext.text = "Successfully bought speed!";
            StartCoroutine(DisplayTextForTime());
        }
        else if (gameController.m_score < priceSpeed)
        {
           Displaytext.text = "Not enough money!!!";
            StartCoroutine(DisplayTextForTime());
        }

    }
    public void BuySword()
    {

    }

    IEnumerator DisplayTextForTime()
    {
        Displaytext.enabled = true;
        yield return new WaitForSeconds(2);
        Displaytext.enabled = false;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
