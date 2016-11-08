using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	/* ideal for game movement code here */
	void FixedUpdate() {
		/* define input horizontal, vertical - keyboard/controller */
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		/* calculate 3D Movement, class of x, y, z of vector in space */
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		/* fixed time update, at 60fps default, every object has transform, pointer
		 * Time.deltaTime, time between last frame, code more consistent, smoother movement, 
		 */
		transform.Translate (movement * Time.deltaTime * speed);
	}

	void OnTriggerEnter(Collider other) {
		/* if I collide with powerup, set active */
		if (other.gameObject.CompareTag("PowerUp")){
			other.gameObject.SetActive(false);
		}
	}
}
