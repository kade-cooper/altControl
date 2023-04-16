using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windScript : MonoBehaviour
{

    private bool playerIn=false;
    public Rigidbody2D player;
    public float windSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerIn){
            player.AddForce(new Vector3(windSpeed,0,0));
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("player")){
            Debug.Log("i work");
            playerIn=true;
        }
    }

    void OnTriggerExit2D(Collider2D other){
        if(other.gameObject.CompareTag("player")){
            playerIn=false;
        }
    }
}
