using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsPlayerAndEnemy : MonoBehaviour
{
    public int enemyFlightDamage;
    public int enemySlimeDamage;
    public int enemyMushRoomDamage;
    // Start is called before the first frame update
    void Start()
    {
        enemyFlightDamage=1;
        enemySlimeDamage=2;
        enemyMushRoomDamage=5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
