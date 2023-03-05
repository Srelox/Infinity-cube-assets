using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Linq;

public class MaterialScript : MonoBehaviour
{

    public AudioSource TimeStopSound;
    public float Energy = 100f;
    bool cooldown = false; 
    bool spellactive = false;

    public Text EnergyText;

    public AudioSource HardMusic;


    public static float CubeScoreMultipliyer = 1f;
    public static float CubeDiffMultipliyer = 1f;
    public GameObject Cube;
    public Material[] material;
    public static int currentMat=0;
    // Start is called before the first frame update
    void Start()
    {

        if(currentMat != 3)
        {
            EnergyText.enabled = false;
        }
        cooldown = false;
        spellactive = false;
        Energy = 100;
        currentMat = PlayerPrefs.GetInt("CurrentMat", currentMat);
        currentMat %= material.Length;
        GetComponent<Renderer>().material = material[currentMat];
        if (currentMat == 0){
            Cube.transform.localScale = new Vector3(0.78f, 0.78f, 0.78f);
            CubeScoreMultipliyer = 0.4f;
            CubeDiffMultipliyer = 0.85f;            
        }

        else if (currentMat == 1){
            Cube.transform.localScale = new Vector3(0.86f, 0.86f, 0.86f);
            CubeScoreMultipliyer = 0.65f;
            CubeDiffMultipliyer = 0.95f;
        }
        else if(currentMat == 3)
        {
            EnergyText.enabled = true;
            CubeScoreMultipliyer = 1.0f;
            CubeDiffMultipliyer = 1.05f;
        }
        else {
            Cube.transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
            CubeScoreMultipliyer = 1.2f;
            CubeDiffMultipliyer = 1.05f;
        }
    }

    // Update is called once per frame
     void Update()
     {
        if(currentMat == 3)
        {
            EnergyText.text = ((float)Mathf.Round(Energy)).ToString();

            if(Input.GetKeyDown(KeyCode.Space) && cooldown == false && Energy > 0 && pauseMenu.GameIsPaused == false )
            {
                spellactive = true;
            }
            
            if(spellactive == true)
            {
                if(!TimeStopSound.isPlaying)
                {
                TimeStopSound.Play();
                HardMusic.Pause();
                }
                if(Energy > 0 && cooldown == false)
                {                
                    spellactive = true;
                    if(pauseMenu.GameIsPaused == false)
                    {
                        Energy -= (43*Time.deltaTime);
                        if(Time.timeScale > 0.4f)
                        {
                            Time.timeScale -= (8f*Time.deltaTime);
                            if(Time.timeScale < 0.4f)
                            {
                                Time.timeScale = 0.4f;
                            }
                            if(Energy <= 0)
                            {   
                                TimeStopSound.Stop();
                                Debug.Log("out of energy 1st script");
                                HardMusic.UnPause();
                                spellactive = false;
                            
                                
                            }
                            
                        }
                    }
                    if(Energy <= 0)
                    {
                        Debug.Log("out of energy 1st script 2");
                        TimeStopSound.Stop();
                        Time.timeScale = 1f;
                        HardMusic.UnPause();
                        spellactive = false;
                    }
                }

            }
            if(currentMat == 3 && Energy <= 0 && cooldown == false && !pauseMenu.GameIsPaused){
                Debug.Log("Cooldown Start");
                HardMusic.UnPause();
                TimeStopSound.Stop();
                cooldown = true;
                Energy = 0;
                Time.timeScale = 1f;
                spellactive = false;
            }
            if(currentMat == 3  && cooldown == true && !pauseMenu.GameIsPaused){
                if(Energy < 100)
                {
                    if(!pauseMenu.GameIsPaused)
                    {
                    Energy += 7.5f*Time.deltaTime;
                    }

                }
                if(Energy >= 100)
                {
                    cooldown = false;
                }
            }
            else if(currentMat == 3 && pauseMenu.GameIsPaused == false && Energy == 100)
            {
                cooldown = false;

            }
        }
        




         
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            currentMat++;
            PlayerPrefs.SetInt("CurrentMat", currentMat);
            currentMat %= material.Length;
            GetComponent<Renderer>().material = material[currentMat];
            if (currentMat == 0){
            Cube.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
            CubeScoreMultipliyer = 0.4f;
            CubeDiffMultipliyer = 0.86f;            
            }

            else if (currentMat == 1){
                Cube.transform.localScale = new Vector3(0.88f, 0.88f, 0.88f);
                CubeScoreMultipliyer = 0.65f;
                CubeDiffMultipliyer = 0.96f;
            }
            
            else {
                Cube.transform.localScale = new Vector3(0.95f, 0.95f, 0.95f);
                CubeScoreMultipliyer = 1.1f;
                CubeDiffMultipliyer = 1.05f;
            }
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Score.globtimer = 0f;
    
           
        }
        
    }

    public void invincibility(){
		 float blinkTime  = 1.5f;
		 float blinkRate  = 0.1f;
         object[] parms = new object[2]{blinkTime,blinkRate};
         StartCoroutine("Blink", parms);
    } 

    IEnumerator Blink(object[] parms)
    {
        float maxSeconds = (float)parms[0];
        float blinkRate = (float)parms[1];
        bool flip = false;
        while(maxSeconds > 0.0f)
        {
            maxSeconds -= blinkRate;
       // for (invincibilityBlinkTime = 0.0f;invincibilityBlinkTime<=maxSeconds;invincibilityBlinkTime+=blinkRate*Time.deltaTime){
            if (flip)
            {
                GetComponent<Renderer>().material = material[5];
                flip = !flip;
            }
            else
            {      
                GetComponent<Renderer>().material = material[4];
                flip = !flip;
            }
            yield return new WaitForSeconds(blinkRate);
        }
        // turn off the blinking
        GetComponent<Renderer>().material = material[4];
    }
        
    
}
