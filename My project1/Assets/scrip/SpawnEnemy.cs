using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ball;
    float spawnTime = 4f;
    [SerializeField] float m_spawnTime = 0f;
    void Start()
    {
        m_spawnTime = spawnTime;
    }
    List<GameObject> balllist;
    // Update is called once per frame
    void Update()
    {
        m_spawnTime -= Time.deltaTime;
        if (m_spawnTime <= 0)
        {
            spawnBall();
            m_spawnTime = spawnTime;
        }
    }
    public void spawnBall()
    {
        Vector2 spawnPos = new Vector2(Random.Range(-10, 5), Random.Range(-4, 4));
        if (ball)
        {
            Instantiate(ball, spawnPos, Quaternion.identity);
        }
    }
}
