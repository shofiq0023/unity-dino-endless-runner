using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpPower = 31;
    public int extraJump = 1;

    [SerializeField] LayerMask groundLayer;
    [SerializeField] Transform feet;

    int jumpCount = 0;
    bool isGrounded;
    float jumpCoolDown;



    // Start is called before the first frame update
    void Start() {}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump();
        }
    }

    void jump()
    {
        rb.velocity = Vector2.up * jumpPower;
        jumpCount++;
    }
    
}
