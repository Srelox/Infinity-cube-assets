using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeData : MonoBehaviour
{

    public Slider slider;

    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("SavedVolume", 0.2f);
        
    }

    // Update is called once per frame
}
