using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicManager : MonoBehaviour
{
    public float moveSpeed = 10;
    public float speedTick = 0;
    public float spawnRateHigh = 2.8f;
    public float spawnRateLow = 1.8f;

    public float moveIncreaseRate = 1;
    public float spawnIncreaseRate = 1;

    public void increaseSpeed()
    {
        if (speedTick > 5)
        {
            moveSpeed += moveIncreaseRate;
            spawnRateHigh += spawnIncreaseRate;
            spawnRateLow += spawnIncreaseRate;
        }
        else
        {
            speedTick += 1;
        }
    }
}
