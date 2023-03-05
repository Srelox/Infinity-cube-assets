using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMovement : MonoBehaviour
{

    public float speed = 0f;
    Vector3 lastPosition = Vector3.zero;
    public Rigidbody rb;
    public float basespeed = -3210f;
    
    public float Scrollspeed =64.2f;
    

    private static float diffspeed;

    void Start()
    {
           
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        diffspeed = Score.difficultyMutl;
        transform.Translate(-Vector3.forward * Time.deltaTime* Scrollspeed * diffspeed, Space.World);
        speed = (transform.position - lastPosition).magnitude;
        lastPosition = transform.position;
 
       /* diffspeed = Score.difficultyMutl;
        rb.velocity  = new Vector3 (rb.velocity.x, rb.velocity.y, basespeed*diffspeed)*Time.deltaTime*2;

        */
    }
}

