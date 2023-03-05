using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text highScore;
    public int highScoreint;

    

    

    // Update is called once per frame
    void Update()
    {
            highScore.text = PlayerPrefs.GetInt("Highscore").ToString();
        
        
        
    }
}
