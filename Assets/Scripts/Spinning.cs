using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinning : MonoBehaviour
{
    // Start is called before the first frame update
    public float spinningspeed = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int randomspeed = Random.Range(10,20);
        transform.Rotate (0, spinningspeed*Time.deltaTime*randomspeed , 0); //rotates 50 degrees per second around z axis
    }
}
