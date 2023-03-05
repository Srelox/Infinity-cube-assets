using UnityEngine;

public class scrollTex : MonoBehaviour
{



    public float speed = 0f;
    Vector3 lastPosition = Vector3.zero;

    public float ScrollSpeed = 1f;


    private static float diffspeed;


    void FixedUpdate()
    {
        diffspeed = Score.difficultyMutl;
        transform.Translate(-Vector3.forward * Time.deltaTime* ScrollSpeed * diffspeed);
        if(transform.position.z < -139){
            transform.position = new Vector3(0, 0, 459.5f);
        }


        
        speed = (transform.position - lastPosition).magnitude;
        lastPosition = transform.position;
        










        /*transform.Translate(0, 0, forwardForce*Time.deltaTime*diffspeed*2);

        /*diffspeed = Score.difficultyMutl;
        rb.velocity  = new Vector3 (rb.velocity.x, rb.velocity.y, -forwardForce*Time.deltaTime*diffspeed*4);
            if(transform.position.z < -140){
            transform.position = new Vector3(0, 0, 460);

    
        /*time += Time.deltaTime*2;
       
        diffspeed = Score.difficultyMutl;
        
        float OffsetX = time * Scrollx;
        float OffsetY = time * Scrolly * diffspeed;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2 (OffsetX, OffsetY);
        */

    }
}
