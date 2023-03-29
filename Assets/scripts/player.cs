using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;
    public Rigidbody2D ropeEnd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        Vector2 moveVec = new Vector2();
        moveVec.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        moveVec.y = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        Vector2 newPosition = this.transform.position + new Vector3(moveVec.x, moveVec.y, 0f);
        this.transform.position = newPosition;
        ropeEnd.AddForce(new Vector2(-moveVec.x,0f));
    }
}
