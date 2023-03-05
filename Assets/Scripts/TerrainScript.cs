using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainScript : MonoBehaviour
{    

	public float forwardForce = 1f;

    public static float diffspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
        diffspeed = Score.difficultyMutl;
        transform.Translate(-Vector3.forward * Time.deltaTime* forwardForce * diffspeed);
        if(transform.position.z < -1320){
            transform.position = new Vector3(-454, -28, 677);

        }
    }
}
