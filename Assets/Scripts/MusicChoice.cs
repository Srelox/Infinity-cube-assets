using UnityEngine;

public class MusicChoice : MonoBehaviour
{
    public AudioSource EasyMusic;
    public AudioSource MediumMusic;
    public AudioSource HardMusic;

    // Start is called before the first frame update
    void Start()
    {
        if (MaterialScript.currentMat == 0){
            EasyMusic.Play();
        }
        else if (MaterialScript.currentMat == 1){
            MediumMusic.Play();
        }
        else{
            HardMusic.Play();

        }
        
    }

}
