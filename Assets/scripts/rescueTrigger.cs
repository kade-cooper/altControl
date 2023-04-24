using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rescueTrigger : MonoBehaviour
{
    public GameObject rescue;
    public GameObject animalBoom;
    
    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("player")){
            Instantiate(animalBoom,this.transform.position + new Vector3(3,0,0),Quaternion.identity);
            other.gameObject.SendMessage("dropOff");
            rescue.gameObject.SendMessage("enableRopeEnd");
        }
    }
}
