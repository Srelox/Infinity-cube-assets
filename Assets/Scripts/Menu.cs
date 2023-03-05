using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public AudioSource Click;
    public Text QualityText;
    public int CurrentQuality;

    private void Start() {
        Scene currentScene = SceneManager.GetActiveScene ();
        if (currentScene.buildIndex== 3){
            QualitySettings.SetQualityLevel(PlayerPrefs.GetInt("Quality", 1));
            QualityText.text = PlayerPrefs.GetString("QualityText", "Quality : Medium");
        }
        if (currentScene.buildIndex == 0){
            CurrentQuality = QualitySettings.GetQualityLevel();
            if (CurrentQuality != PlayerPrefs.GetInt("Quality", 1)){
                QualitySettings.SetQualityLevel(PlayerPrefs.GetInt("Quality", 1));
            }
            
        }

    }
    public void StartGame()
    {
        Click.Play();
        SceneManager.LoadScene(1);
    }
    public void Shop ()
    {
        Click.Play();
        SceneManager.LoadScene(2);
    }
    public void MainMenu()
    {
        Click.Play();
        Debug.Log("mainmenu");
        SceneManager.LoadScene(0);
    }
    public void Settings()
    {
        Click.Play();
        SceneManager.LoadScene(3);
    }
    public void HighSettings(){
        Click.Play();
        QualitySettings.SetQualityLevel(2);
        QualityText.text="Quality : High";
        PlayerPrefs.SetInt("Quality", 2);
        PlayerPrefs.SetString("QualityText", "Quality : High");
    }
    public void MediumSettings(){
        Click.Play();
        QualitySettings.SetQualityLevel(1);
        QualityText.text="Quality : Medium";
        PlayerPrefs.SetInt("Quality", 1);
        PlayerPrefs.SetString("QualityText", "Quality : Medium");
    }

    public void LowSettings(){
        QualitySettings.SetQualityLevel(0);
        QualityText.text="Quality : Low";
        PlayerPrefs.SetInt("Quality", 0);
        PlayerPrefs.SetString("QualityText", "Quality : Low");
    }

    public void Quit(){
        
         Debug.Log("quit");
		 Application.Quit();
    	 
    }

}