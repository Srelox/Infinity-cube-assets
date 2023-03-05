using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour

{
    public static float HighScore = 0f;
    public static float globtimer = 0f;
    public static int scoreTime = 0;
    public Text scoreText;

    public float diffSetting = 0.01f;
    public static float difficultyMutl  = 0.95f;
    void Start() {
        scoreTime = 0;
        difficultyMutl = 1.0f*MaterialScript.CubeDiffMultipliyer;
        PlayerPrefs.GetInt("Highscore", 0).ToString();
        HighScore = PlayerPrefs.GetInt("Highscore");
    }
    void FixedUpdate()
    {
        

        globtimer += Time.deltaTime;

        difficultyMutl += diffSetting*Time.deltaTime/10;
        scoreTime = Mathf.RoundToInt(globtimer*17*MaterialScript.CubeScoreMultipliyer);
        scoreText.text = scoreTime.ToString();
        if(scoreTime > PlayerPrefs.GetInt("Highscore")){
            PlayerPrefs.SetInt("Highscore", scoreTime);
            HighScore = scoreTime;

        }
    }
}
