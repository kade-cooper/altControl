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
    public Transform rope;
    public Rigidbody2D playerR2D;
    public GameObject person;
    public GameObject animalModel;
    private int carried=0;
    public int maxCarried=4;
    public TextMeshProUGUI capacity;
    public Transform modelLocation;
    public bool paused=false;
    private int rescued=0;
    public GameObject winMenuUI;
    public AudioSource audio;
    public AudioSource audio2;
    public GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        InvokeRepeating("PlaySound",0.001f,.8f);
    }

    void PlaySound(){
        audio.Play();
        audio2.Play();
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

        if(!paused && Input.GetAxis("Mouse Y")<0 && ropeStart.position.y<modelLocation.position.y+4){
            rope.position=new Vector2(rope.position.x,rope.position.y+ropeSpeed);
        }
        if(!paused && Input.GetAxis("Mouse Y")>0 && ropeStart.position.y>modelLocation.position.y){
            rope.position=new Vector2(rope.position.x,rope.position.y-ropeSpeed);
        }
    }
    public void enablePerson(){
        animalModel.gameObject.GetComponent<Renderer> ().enabled = true;
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
        rescued+=carried;
        carried=0;
        if(rescued==8){
            winMenuUI.SetActive(true);
            pauseEnabled();
            pauseMenu.SendMessage("togglePauseBool");
            Time.timeScale = 0f;
        }
        capacity.text="Capacity: "+carried+"/4";
    }

    public void pauseEnabled(){
        paused=true;
    }
    public void pauseDisabled(){
        paused=false;
    }
}
