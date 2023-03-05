using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volume : MonoBehaviour
{
 private AudioSource AudioSrc;
 
 private float AudioVolume = 0.35f;
 
 void Start () {
  AudioSrc = GetComponent<AudioSource>();
  AudioSrc.volume = PlayerPrefs.GetFloat("SavedVolume", 0.2f);
 }
 
 
 public void SetVolume(float vol)
 {
  AudioVolume = vol;
  PlayerPrefs.SetFloat("SavedVolume", vol);
  AudioSrc.volume = PlayerPrefs.GetFloat("SavedVolume", 0.2f);
  FindObjectOfType<DeathSoundVol>().DeathSoundUpdate();
 }
}