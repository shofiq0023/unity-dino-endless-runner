using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicManager : MonoBehaviour
{
    public float moveSpeedLimit;

    public float moveSpeed;

    public float speedIncreaseRate;

    private void FixedUpdate() {
        moveSpeed += speedIncreaseRate;

        if (moveSpeed > moveSpeedLimit) {
            moveSpeed = moveSpeedLimit;
        }
    }
}
