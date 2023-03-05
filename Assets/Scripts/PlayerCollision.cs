using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public PlayerMovement movement;	
	public AudioSource colidSound;
	public static bool invincibility = false;
	public int life = 1;
	public float targetTime = 2.0f;


		// A reference to our PlayerMovement script
	void Start() {
		colidSound = GetComponent<AudioSource>();
		invincibility = false;
		targetTime = 1.5f;
		life = 1;
	}
	void Update() {
		Physics.IgnoreLayerCollision(11, 12, invincibility);
		if(invincibility)
		{
			targetTime -= Time.deltaTime;
			if (targetTime <= 0.0f)
			{
				invincibility = false;
			}
		}
		
	}

	// This function runs when we hit another object.
	// We get information about the collision and call it "collisionInfo".
	void OnCollisionEnter (Collision collisionInfo)
	{
		// We check if the object we collided with has a tag called "Obstacle".

		if (collisionInfo.collider.tag == "Obstacle")
		{
			if (((MaterialScript.currentMat == 4) || (MaterialScript.currentMat == 5)) && !invincibility){
				if (life == 0)
				{
				colidSound.Play();
				movement.enabled = false;	// Disable the players movement.
				FindObjectOfType<GMscript>().EndGame();
				invincibility = false;
				}
				
				else{
					colidSound.Play();
					life = 0;
					Debug.Log("one life left ");
					targetTime = 1.5f;
					invincibility = true;
					FindObjectOfType<MaterialScript>().invincibility();

				}
			
			}
			else
			{

			colidSound.Play ();
			
			movement.enabled = false;	// Disable the players movement.
			FindObjectOfType<GMscript>().EndGame();
			}
		}
	}


}
