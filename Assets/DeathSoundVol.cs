using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathSoundVol : MonoBehaviour
{
     private AudioSource AudioSrc;
 
    
    void Start()
    {
      AudioSrc = GetComponent<AudioSource>();
      AudioSrc.volume = PlayerPrefs.GetFloat("SavedVolume", 0.2f) * 3f;
    }

    public void DeathSoundUpdate()
    {
        AudioSrc.volume = PlayerPrefs.GetFloat("SavedVolume", 0.2f) * 3f;
    }
}
