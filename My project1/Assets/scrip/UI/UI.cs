using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class UI : MonoBehaviour
{
    // Start is called before the first frame update
    public Text m_Score;
    public GameObject gameover_Panel;

    public void textScore(string text)
    {
        if (m_Score)
        {
            m_Score.text = text;
        }
    }
    public void ShowPanel(bool show)
    {
        if (show)
        {
            gameover_Panel.SetActive(show);
        }
    }
}
