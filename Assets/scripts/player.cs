using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;
    public float vertSpeed;
    public float ropeSpeed;
    public Rigidbody2D ropeEnd;
    public GameObject ropeEndO;
    public Transform ropeStart;
    public Rigidbody2D playerR2D;
    public GameObject person;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        Vector2 moveVec = new Vector2();
        moveVec.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        moveVec.y = Input.GetAxis("Vertical") * vertSpeed * Time.deltaTime;
        Vector2 force = new Vector3(moveVec.x, 0f, 0f);
        Vector2 newPosition = this.transform.position + new Vector3(0f, moveVec.y, 0f);
        this.transform.position = newPosition;
        playerR2D.AddForce(force);
        ropeEnd.AddForce(new Vector2(-moveVec.x*0.2f,0f));

        if(Input.GetAxis("Mouse Y")<0 && ropeStart.position.y<=this.transform.position.y+1){
            ropeStart.position=new Vector2(ropeStart.position.x,ropeStart.position.y+ropeSpeed);
        }
        Debug.Log(ropeStart.position.y>=this.transform.position.y);
        Debug.Log(ropeStart.position.y+"rope");
        Debug.Log(this.transform.position.y+"player");
        if(Input.GetAxis("Mouse Y")>0 && ropeStart.position.y>=this.transform.position.y-3){
            ropeStart.position=new Vector2(ropeStart.position.x,ropeStart.position.y-ropeSpeed);
        }
    }
    public void enablePerson(){
        person.gameObject.GetComponent<Renderer> ().enabled = true;
        ropeEndO.tag = "ropeEndDisabled";
        Debug.Log(ropeEndO.tag);
    }

    
}
