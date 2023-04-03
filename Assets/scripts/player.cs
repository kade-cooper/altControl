using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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
    public int carried=0;
    public int maxCarried=4;
    public TextMeshProUGUI capacity;
    public Transform modelLocation;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
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

        if(Input.GetAxis("Mouse Y")<0 && ropeStart.position.y<=modelLocation.position.y+1){
            ropeStart.position=new Vector2(ropeStart.position.x,ropeStart.position.y+ropeSpeed);
        }
        if(Input.GetAxis("Mouse Y")>0 && ropeStart.position.y>=modelLocation.position.y-3){
            ropeStart.position=new Vector2(ropeStart.position.x,ropeStart.position.y-ropeSpeed);
        }
    }
    public void enablePerson(){
        person.gameObject.GetComponent<Renderer> ().enabled = true;
        ropeEndO.tag = "ropeEndDisabled";
        Debug.Log(ropeEndO.tag);
    }
    public void addCarried(){
        carried+=1;
        capacity.text="Capacity: "+carried+"/4";
        if(carried<maxCarried){
            person.gameObject.SendMessage("enableRopeEnd");
        }
    }
    public void dropOff(){
        carried=0;
        capacity.text="Capacity: "+carried+"/4";
    }
    
}
