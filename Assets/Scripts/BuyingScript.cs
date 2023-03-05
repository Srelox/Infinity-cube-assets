using UnityEngine;
using UnityEngine.UI;
public class BuyingScript : MonoBehaviour
{
    public AudioSource DenySound;
    public AudioSource Click;

    public Image Select0;
    public Image Select1;

    public Image Select2;

    public Image Select3;
    public Image Select4;
    public Image Select5;




    public int Yellowlocked = 1;
    public int Redlocked = 1;
    public int Bluelocked = 1;
    public int Pinklocked = 1;

    // Start is called before the first frame update


    // Update is called once per frame
    private void Start() {
        Score.HighScore = PlayerPrefs.GetInt("Highscore", 0);
        MaterialScript.currentMat = PlayerPrefs.GetInt("CurrentMat", 0);
        if(MaterialScript.currentMat == 0)
        {
            Select0.enabled = true;
            Select1.enabled = false;
            Select2.enabled = false;
            Select3.enabled = false;
            Select4.enabled = false;
            Select5.enabled = false;
        }
        else if(MaterialScript.currentMat == 1)
        {
            Select0.enabled = false;
            Select1.enabled = true;
            Select2.enabled = false;
            Select3.enabled = false;
            Select4.enabled = false;
            Select5.enabled = false;
        }
        else if(MaterialScript.currentMat == 2)
        {
            Select0.enabled = false;
            Select1.enabled = false;
            Select2.enabled = true;
            Select3.enabled = false;
            Select4.enabled = false;
            Select5.enabled = false;
        }
        else if(MaterialScript.currentMat == 3)
        {
            Select0.enabled = false;
            Select1.enabled = false;
            Select2.enabled = false;
            Select3.enabled = true;
            Select4.enabled = false;
            Select5.enabled = false;
        }
        else if(MaterialScript.currentMat == 4)
        {
            Select0.enabled = false;
            Select1.enabled = false;
            Select2.enabled = false;
            Select3.enabled = false;
            Select4.enabled = true;
            Select5.enabled = false;
        }
        else if(MaterialScript.currentMat == 5)
        {
            Select0.enabled = false;
            Select1.enabled = false;
            Select2.enabled = false;
            Select3.enabled = false;
            Select4.enabled = false;
            Select5.enabled = true;
        }
    }

    public void GreenCube(){
        Click.Play();
        MaterialScript.currentMat = 0;
        PlayerPrefs.SetInt("CurrentMat", MaterialScript.currentMat);
        Select0.enabled = true;
            Select1.enabled = false;
            Select2.enabled = false;
            Select3.enabled = false;
            Select4.enabled = false;
            Select5.enabled = false;

    } 
    public void BuyYellowCube(){
        if(PlayerPrefs.GetInt("Yellowlocked", 1) == 1){
            if(Score.HighScore > 300 ){
                Click.Play();
                Yellowlocked = 0;
                PlayerPrefs.SetInt("Yellowlocked", 0);
                MaterialScript.currentMat = 1;
                PlayerPrefs.SetInt("CurrentMat", MaterialScript.currentMat);
                Select0.enabled = false;
                Select1.enabled = true;
                Select2.enabled = false;
                Select3.enabled = false;
                Select4.enabled = false;
                Select5.enabled = false;

            }
            else{
                Debug.Log("Pas assez de crédits");
                DenySound.Play();
            }
        }
        else{
            MaterialScript.currentMat = 1;
            PlayerPrefs.SetInt("CurrentMat", MaterialScript.currentMat);
            Click.Play();
            Select0.enabled = false;
            Select1.enabled = true;
            Select2.enabled = false;
            Select3.enabled = false;
            Select4.enabled = false;
            Select5.enabled = false;
        }
    }

    public void BuyRedCube(){
        if(PlayerPrefs.GetInt("Redlocked", 1) == 1){
            if(Score.HighScore > 650 ){
                Click.Play();
                Redlocked = 0;
                PlayerPrefs.SetInt("Redlocked", 0);
                MaterialScript.currentMat = 2;
                PlayerPrefs.SetInt("CurrentMat", MaterialScript.currentMat);
                Select0.enabled = false;
                Select1.enabled = false;
                Select2.enabled = true;
                Select3.enabled = false;
                Select4.enabled = false;
                Select5.enabled = false;
            }
            else{
                Debug.Log("Pas assez de crédits");
                DenySound.Play();
            }
        }
        else{
            MaterialScript.currentMat = 2;
            PlayerPrefs.SetInt("CurrentMat", MaterialScript.currentMat);
            Click.Play();
            Select0.enabled = false;
            Select1.enabled = false;
            Select2.enabled = true;
            Select3.enabled = false;
            Select4.enabled = false;
            Select5.enabled = false;

        }
    }
    public void BuyBlueCube()
    {
        if(PlayerPrefs.GetInt("Bluelocked", 1) == 1){
            if(Score.HighScore > 850 ){
                Click.Play();
                Bluelocked = 0;
                PlayerPrefs.SetInt("Bluelocked", 0);
                MaterialScript.currentMat = 3;
                PlayerPrefs.SetInt("CurrentMat", MaterialScript.currentMat);
                Select0.enabled = false;
                Select1.enabled = false;
                Select2.enabled = false;
                Select3.enabled = true;
                Select4.enabled = false;
                Select5.enabled = false;
            }
            else{
                Debug.Log("Pas assez de crédits");
                DenySound.Play();
            }
        }
        else{
            MaterialScript.currentMat = 3;
            PlayerPrefs.SetInt("CurrentMat", MaterialScript.currentMat);
            Click.Play();
            Select0.enabled = false;
            Select1.enabled = false;
            Select2.enabled = false;
            Select3.enabled = true;
            Select4.enabled = false;
            Select5.enabled = false;
            

        }
    }
    public void Resetall()
    {
        Click.Play();
        MaterialScript.currentMat = 0;
        PlayerPrefs.SetInt("CurrentMat", MaterialScript.currentMat);
        Select0.enabled = true;
        Select1.enabled = false;
        Select2.enabled = false;
        Select3.enabled = false;
        Select4.enabled = false;
        Select5.enabled = false;
        PlayerPrefs.SetInt("Yellowlocked", 1);
        PlayerPrefs.SetInt("Redlocked", 1);
        PlayerPrefs.SetInt("Bluelocked", 1);
        PlayerPrefs.SetInt("Pinklocked", 1);
        PlayerPrefs.SetInt("Highscore", 0);
        Score.HighScore = PlayerPrefs.GetInt("Highscore", 0);
    }

    public void BuyPinkCube()
    {
        if(PlayerPrefs.GetInt("Pinklocked", 1) == 1){
            if(Score.HighScore > 1000 ){
                Click.Play();
                Pinklocked = 0;
                PlayerPrefs.SetInt("Pinklocked", 0);
                MaterialScript.currentMat = 4;
                PlayerPrefs.SetInt("CurrentMat", MaterialScript.currentMat);
                Select0.enabled = false;
                Select1.enabled = false;
                Select2.enabled = false;
                Select3.enabled = false;
                Select4.enabled = false;
                Select5.enabled = true;
            }
            else{
                Debug.Log("Pas assez de crédits");
                DenySound.Play();
            }
        }
        else{
            MaterialScript.currentMat = 4;
            PlayerPrefs.SetInt("CurrentMat", MaterialScript.currentMat);
            Click.Play();
            Select0.enabled = false;
            Select1.enabled = false;
            Select2.enabled = false;
            Select3.enabled = false;
            Select4.enabled = false;
            Select5.enabled = true;

        }
    }
}