using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorScript : MonoBehaviour
{
    
    [SerializeField]
    float moveSpeed;
    
    [SerializeField]
    float speedLimit;

    [SerializeField]
    float speedIncreaseRate;

    private float deadZone = -30;

    private LogicManager logic;

    void Start() 
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
        moveSpeed = logic.moveSpeed;
        speedLimit = logic.moveSpeedLimit;
        speedIncreaseRate = logic.speedIncreaseRate;
        Debug.Log(moveSpeed);
    }

    void FixedUpdate()
    {
        // Move the floor every frame
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        // Increase move speed
        moveSpeed += speedIncreaseRate;
        
        if (moveSpeed > speedLimit) 
        {
            moveSpeed = speedLimit;
        }

        // Destroys object after reaching spicific x position
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
