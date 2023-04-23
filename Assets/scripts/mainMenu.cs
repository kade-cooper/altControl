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
    public void Play(){
        SceneManager.LoadScene("SampleScene");
    }   

    public void Controls(){
        SceneManager.LoadScene("Menu");
    }
}
