using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] enemy;
    float spawnTime = 0.3f;
    public Transform cameraTranform;
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
        Vector2 spawnPos1 = new Vector2(Random.Range(cameraTranform.position.x - 13, cameraTranform.position.x + 13), cameraTranform.position.y+7+3);
        Vector2 spawnPos2 = new Vector2(Random.Range(cameraTranform.position.x - 13, cameraTranform.position.x + 13), cameraTranform.position.y - 7 - 3);
        Vector2 spawnPos3 = new Vector2(cameraTranform.position.x - 13 - 3,Random.Range(cameraTranform.position.y - 7, cameraTranform.position.y + 7));
      //  Vector2 spawnPos4 = new Vector2(cameraTranform.position.x + 13 + 3, Random.Range(cameraTranform.position.y - 7, cameraTranform.position.y + 7));
        int randomPosition = Random.Range(1, 5);
        int randomRateEnemy= Random.Range(1,101);
        int randomEnemy=-1;

        if (randomRateEnemy <= 60)
        {
            randomEnemy = 1;

        }
        if (randomRateEnemy > 60 && randomRateEnemy<=90)
        {
            randomEnemy = 0;

        }
        if (randomRateEnemy > 90 && randomRateEnemy < 100)
        {
            randomEnemy = 2;

        }
        if (randomPosition == 1)
        {
            Instantiate(enemy[randomEnemy], spawnPos1, Quaternion.identity);
        }
        if (randomPosition == 2)
        {
            Instantiate(enemy[randomEnemy], spawnPos2, Quaternion.identity);
        }
        if (randomPosition == 3)
        {
           // Instantiate(enemy[randomEnemy], spawnPos3, Quaternion.identity);
        }
        if (randomPosition == 4)
        {
            //Instantiate(enemy[randomEnemy], spawnPos4, Quaternion.identity);
        }

    }
}
