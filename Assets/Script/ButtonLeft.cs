using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class ButtonLeft : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject player;

    public void OnPointerDown(PointerEventData eventData)       // 눌리고 있을 때
    {
        player.GetComponent<PlayerController>().moveHorizonal = -1;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        player.GetComponent<PlayerController>().moveHorizonal = 0;
    }
}
