using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timerScript : MonoBehaviour
{
    float timer = 60f;
    public TextMeshProUGUI time;
    public GameObject failMenuUI;
    public GameObject player;

void Update() 
{     
  if(timer>0)     
  {         
    timer -= Time.deltaTime;     
  }     
  double b = System.Math.Round (timer, 2);     
  time.text = b.ToString ();     
  if(timer < 0)     
  {         
    failMenuUI.SetActive(true);
    Time.timeScale = 0f;
    player.SendMessage("pauseEnabled");    
  } 
}
}
