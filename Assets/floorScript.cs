using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorScript : MonoBehaviour
{
    public LogicManager logic;
    public float moveSpeed = 10;
    public float deadZone = -30;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
        moveSpeed = logic.moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
            logic.increaseSpeed();
            Debug.Log(moveSpeed);
        }
    }
}
