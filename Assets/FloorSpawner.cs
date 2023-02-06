using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawner : MonoBehaviour
{
    public GameObject floor;

    [SerializeField]
    float heighOffset;

    [SerializeField]
    float spawnRate;

    [SerializeField]
    float spawnRateHigh;

    [SerializeField]
    float spawnRateLow;

    [SerializeField]
    float spawnDifference;

    [SerializeField]
    float spawnRateLowSubLimit;

    [SerializeField]
    float spawnRateHighSubLimit;

    private float timer = 0;
    
    // Start is called before the first frame update
    void Start() {}

    // Update is called once per frame
    void Update()
    {
        spawnRateLow -= spawnDifference;
        spawnRateHigh -= spawnDifference;

        if (spawnRateLow < spawnRateLowSubLimit) {
            spawnRateLow = spawnRateLowSubLimit;
        }
        if (spawnRateHigh < spawnRateHighSubLimit) {
            spawnRateHigh = spawnRateHighSubLimit;
        }

        if(timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawn();
            timer = 0;
            spawnRate = Random.Range(spawnRateLow, spawnRateHigh);
        }
    }
    
    void spawn()
    {
        float highestPoint = transform.position.y - heighOffset;
        float lowestPoint = transform.position.y + heighOffset;

        Instantiate(floor, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), gameObject.transform.rotation);
    }
}
