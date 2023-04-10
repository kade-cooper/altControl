using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class rescueable : MonoBehaviour
{
    private GameObject player;
    public GameObject capacity;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("ropeEnd")){
            player.SendMessage("enablePerson");
            Destroy(this.gameObject, 0f);
            Debug.Log(capacity);
        }
        else if(other.gameObject.CompareTag("ropeEndDisabled")){
            capacity.SetActive(true);
        }
    }
    private void OnCollisionExit2D(Collision2D other){
        if(other.gameObject.CompareTag("ropeEndDisabled")){
            capacity.SetActive(true);
        }
    }
    void Start(){
        player = GameObject.FindWithTag("player");
        Debug.Log(capacity);
        //capacitytxt = text.Find("atCapacity");
    }
}
