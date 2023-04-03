using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rescue : MonoBehaviour
{
    public GameObject ropeEndO;

    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("player")){
            this.gameObject.GetComponent<Renderer> ().enabled = false;
            ropeEndO.gameObject.tag = "ropeEnd";
        }
    }
}
