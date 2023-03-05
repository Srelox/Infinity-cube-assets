using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public AudioSource colidSound;
	public Rigidbody rb;
	
	public float antislippery = 3f;

	public float forwardForce = 800f;	// Variable that determines the forward force

	public float shiftmultiplier = 1.5f;

	private float time = 0f;
	public float sidewaysForce = 140f;  // Variable that determines the sideways force
	void Start() {
		rb.drag = 2;
		time = 0f;
	}
	
 	
	void FixedUpdate()
	{	
		if(Input.GetKey(KeyCode.LeftShift))
			rb.velocity = new Vector3(0, rb.velocity.y, 0);

		if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))	// If the player is pressing the "d" key
		{
			time = 0f;
			rb.drag = 2f;
			rb.AddForce(sidewaysForce*0.95f * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
			
			//rb.velocity  = new Vector3 (sidewaysForce * Time.deltaTime, rb.velocity.y, rb.velocity.z);	
		}
		
		else if (Input.GetKey("q") || Input.GetKey(KeyCode.LeftArrow))  // If the player is pressing the "a" key
		{	
			time = 0f;
			//rb.velocity  = new Vector3 (-sidewaysForce * Time.deltaTime, rb.velocity.y, rb.velocity.z);
			rb.AddForce(-sidewaysForce*0.95f * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
			rb.drag = 2f;

		}
		else{
			time += Time.deltaTime;
			rb.drag = antislippery*1.1f+time*2;
		}

		if (rb.position.y < -1f)
		{
			FindObjectOfType<GMscript>().EndGame();

		}
		

    }
}