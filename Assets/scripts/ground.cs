using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground : MonoBehaviour
{
    public GameObject player;

    private void onCollisionEnter2D(Collision2D other){
        if(other.gameObject.CompareTag("player")){
            Debug.Log("plz work");
            Destroy(player);
        }
    }
}
