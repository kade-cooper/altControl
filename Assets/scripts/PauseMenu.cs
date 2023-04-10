using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public static bool GameIsPaused = false;
    public bool CanPause=true;
    public GameObject pauseMenuUI;
    public GameObject player;
    

    // Update is called once per frame
    void Update() {
       if (Input.GetKeyDown(KeyCode.Escape)&&CanPause)
        {
            if (GameIsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
    }

public void Resume ()
{
    pauseMenuUI.SetActive(false);
    Time.timeScale = 1f;
    GameIsPaused = false;
    player.SendMessage("pauseDisabled");

}

public void Pause ()
{
    pauseMenuUI.SetActive(true);
    Time.timeScale = 0f;
    GameIsPaused = true;
    player.SendMessage("pauseEnabled");
}
public void Quit(){
    Application.Quit();
    //UnityEditor.EditorApplication.isPlaying = false;
}
public void Menu(){
    SceneManager.LoadScene("Menu");
    Time.timeScale = 1f;
}
public void Restart(){
    SceneManager.LoadScene("SampleScene");
    Time.timeScale = 1f;
}
public void togglePauseBool(){
    CanPause = false;
}
    }
