using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{

    public void Quit(){
        Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false;
    
    }
    public void Lvl1(){
        SceneManager.LoadScene("SampleScene");
    }   
    public void Lvl2(){
        SceneManager.LoadScene("level2");
    }   

    public void Controls(){
        SceneManager.LoadScene("Menu");
    }
}
