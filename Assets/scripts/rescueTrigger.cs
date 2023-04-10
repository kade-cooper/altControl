using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rescueTrigger : MonoBehaviour
{
    public GameObject rescue;
    
    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("player")){
            other.gameObject.SendMessage("dropOff");
            rescue.gameObject.SendMessage("enableRopeEnd");
        }
    }
}
