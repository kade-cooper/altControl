using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rescue : MonoBehaviour
{
    public GameObject ropeEndO;
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("player") && this.gameObject.GetComponent<Renderer> ().enabled){
            this.gameObject.GetComponent<Renderer> ().enabled = false;
            player.gameObject.SendMessage("addCarried");
        }
    }
    private void enableRopeEnd(){
        ropeEndO.gameObject.tag = "ropeEnd";
    }
}
