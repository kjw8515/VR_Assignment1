using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonJump : MonoBehaviour
{
    public GameObject player;

    public void Jump()                                                  // 물체에 기본적으로 RigidBody로 중력 적용
    {
        player.GetComponent<PlayerController>().Jump();
    }
    
}
