using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEditor.Tilemaps;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] gameobjectlist;
    public float spawnTime;
    [SerializeField] float m_spawnTime;
    int m_score;
    bool m_isOver;
    UI m_UI;
    float power;
    void Start()
    {
        m_UI = FindObjectOfType<UI>();
        m_UI.textScore("Coin:" + m_score);
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    private void Reset()
    {
        m_UI.ShowPanel(false);
        m_score = 0;
        m_UI.textScore("Coin:" + m_score);

    }
    public void setScore(int value)
    {
        m_score = value;
    }
    public int getScore()
    {
        return m_score;
    }
    public void incrementSscore()
    {
        m_score++;
        m_UI.textScore("Coin:" + m_score);
    }
    public void decrementSscore()
    {
        m_score--;
        m_UI.textScore("Coin:" + m_score);
    }
    public void setGameover(bool state)
    {
        m_isOver = state;
    }
    public bool isOver()
    {
        return m_isOver;
    }
}
