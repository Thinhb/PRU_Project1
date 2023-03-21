using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillManager : MonoBehaviour
{
    public int priceHealth = 50;
    public int priceSpeed = 50;
    public int priceGun = 50;
    public Text Displaytext;
    //public HealthHitCharacter healthHitCharacter;
    public PlayerHealth playerHealth;
    public playerMove playermove;
    public UI ui;
    public GameController gameController;
    public bullet bullet;
    public WeaponGun weaponGun;

    public void Buyhealth()
    {
        if ( 0 < playerHealth.currentHealth && playerHealth.currentHealth < playerHealth.maxHealth && gameController.m_score >= priceHealth)
        {
            playerHealth.currentHealth += 5;
            gameController.m_score -= priceHealth;
            ui.m_Score.text="Coin:" + gameController.m_score;
            Displaytext.text = "Successfully bought blood!";
            StartCoroutine(DisplayTextForTime());
        }
        else if (gameController.m_score < priceHealth)
        {
            Displaytext.text = "Not enough money buy health!!!";
            //ui.m_Score.text = "Coin:" + gameController.m_score;
            StartCoroutine(DisplayTextForTime());
            
        }
        if (playerHealth.currentHealth == playerHealth.maxHealth)
        {
            playerHealth.currentHealth += 0;
            ui.textScore("Coin:" + gameController.m_score);
            Displaytext.text = "Full of bool!";
            StartCoroutine(DisplayTextForTime());
        }
    }
    public void BuySeep()
    {
        if (gameController.m_score > priceSpeed)
        {
            playermove.moveSpeed += 10;
            gameController.m_score -= priceSpeed;
            ui.m_Score.text = "Coin:" + gameController.m_score;
            Displaytext.text = "Successfully bought speed!";
            StartCoroutine(DisplayTextForTime());
        }
        else
        {
            //ui.m_Score.text = "Coin:" + gameController.m_score;
            Displaytext.text = "Not enough money buy speed!!!";
            StartCoroutine(DisplayTextForTime());
        }

    }
    public void BuyGun()
    {
        if (gameController.m_score > priceGun)
        {
            bullet.damage += 2;
            weaponGun.timerdelay += 0.05f;
            gameController.m_score -= priceGun;
            ui.m_Score.text = "Coin:" + gameController.m_score;
            Displaytext.text = "Successfully bought damage bullet!";
            StartCoroutine(DisplayTextForTime());
        }
        else
        {
            Displaytext.text = "Not enough money buy damage bullet!!!";
            StartCoroutine(DisplayTextForTime());
        }

    }

    IEnumerator DisplayTextForTime()
    {
        Displaytext.enabled = true;
        yield return new WaitForSeconds(1);
        Displaytext.enabled = false;
    }

    void Start()
    {
        gameController = GameObject.FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
