using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ropeAlpha : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("i run2");
        if(other.gameObject.CompareTag("ropeEnd") || other.gameObject.CompareTag("rope")){
            //Debug.Log("i run");
            other.gameObject.GetComponent<Renderer> ().enabled = false;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("ropeEnd") || other.gameObject.CompareTag("rope")){
            other.gameObject.GetComponent<Renderer> ().enabled = true;
        }
    }
}
