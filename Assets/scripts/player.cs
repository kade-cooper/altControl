using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;
    public float vertSpeed;
    public Rigidbody2D ropeEnd;
    public Rigidbody2D playerR2D;
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
    }
}
