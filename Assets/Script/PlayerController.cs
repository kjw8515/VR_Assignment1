using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveHorizonal;
    public float moveVertical;
    public float moveJump;
    public float speed;

    public float Yaxis = 0;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void FixedUpdate()
    {
        speed = 3;
        rb.velocity = transform.forward.normalized * moveVertical *speed + transform.right.normalized * moveHorizonal*speed + transform.up.normalized * moveJump;
        if (transform.position.y >= Yaxis)
        {
            moveJump = -5.0f;                // 중력 가속도 적용(기본적으로 물체 RigidBody에서 중력 적용되어 있음)
            Yaxis = 0;
        }
    }

    public void Jump()
    {
        moveJump = 5;                  // 중력 가속도 반작용 힘
        Yaxis = transform.position.y + 3;   // 높이 조절. 
    }
}
