using UnityEngine.UI;
using UnityEngine;

public class VolumeText : MonoBehaviour
{
    public Text volumeTextdisplayed;
    private float tempvolume;
    // Start is called before the first frame update
    void Start()
    {
        tempvolume = PlayerPrefs.GetFloat("SavedVolume");
        volumeTextdisplayed.text = ((float)Mathf.Round(tempvolume * 100f)).ToString() + "%";
    }

    // Update is called once per frame
    void Update()
    {

        tempvolume = PlayerPrefs.GetFloat("SavedVolume");
        volumeTextdisplayed.text = ((float)Mathf.Round(tempvolume * 100f)).ToString() + "%";

    }
}
