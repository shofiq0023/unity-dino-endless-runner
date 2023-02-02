using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawner : MonoBehaviour
{
    public GameObject floor;
    public LogicManager logic;
    public float heighOffset;
    public float spawnRate;
    private float timer = 0;
    public float spawnRateHigh;
    public float spawnRateLow;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
        spawnRateHigh = logic.spawnRateHigh;
        spawnRateLow = logic.spawnRateLow;
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawn();
            timer = 0;
            spawnRate = Random.Range(1.8f, 2.8f);
        }
    }
    
    void spawn()
    {
        float highestPoint = transform.position.y - heighOffset;
        float lowestPoint = transform.position.y + heighOffset;

        Instantiate(floor, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), gameObject.transform.rotation);
    }
}
