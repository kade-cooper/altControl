using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rescueable : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("ropeEnd")){
            player.SendMessage("enablePerson");
            Destroy(this.gameObject, 0f);
        }
    }
}
