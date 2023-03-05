using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenu : MonoBehaviour
{
    private void Start() {
        GameIsPaused = false;
        Time.timeScale = 1f;
    }
    public static bool GameIsPaused = false;

    public GameObject PauseMenuUi;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (GameIsPaused){
                Resume();
            
            } 
            else
            {
                 Pause();
            }
        }  
    }
    public void ResetHighscore(){
        PlayerPrefs.SetInt("Highscore", 0);
        PauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void Resume()
    {
        PauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
    {
        PauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void QuitGame(){
        
         Debug.Log("quitgame");
		 Application.Quit();
    	 
    }
    
}
