using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heliAnim : MonoBehaviour
{

    public Animator anim;
    public void moveRight(){
        Debug.Log("i run");
        anim.SetTrigger("moveRight");
    }
    public void moveLeft(){
        anim.SetTrigger("moveLeft");
    }
    public void idle(){
        anim.SetTrigger("idle");
    }
}
