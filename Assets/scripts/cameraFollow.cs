using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;
  
  void Update () 
  {
    player = GameObject.FindWithTag("player");
    transform.position = new Vector3 (player.transform.position.x + offset.x, player.transform.position.y + offset.y, offset.z); 
  } 
}
