using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ground : MonoBehaviour
{
    public GameObject playerPrefab;
    public string currentLevel;

    private void OnCollisionEnter2D(Collision2D other){
        //Debug.Log("plz work");
        if(other.gameObject.CompareTag("player")){
            //Debug.Log("plz work");
            Destroy(other.gameObject);
            //Instantiate(playerPrefab, new Vector3(-6,2,0), Quaternion.identity);
            SceneManager.LoadScene(currentLevel);
        }
    }
}
