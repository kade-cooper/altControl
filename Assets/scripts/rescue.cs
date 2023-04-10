using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rescue : MonoBehaviour
{
    public GameObject ropeEndO;
    public GameObject player;
    public GameObject animalModel;

    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("player") && animalModel.gameObject.GetComponent<Renderer> ().enabled){
            animalModel.gameObject.GetComponent<Renderer> ().enabled = false;
            player.gameObject.SendMessage("addCarried");
        }
    }
    private void enableRopeEnd(){
        ropeEndO.gameObject.tag = "ropeEnd";
    }
}
