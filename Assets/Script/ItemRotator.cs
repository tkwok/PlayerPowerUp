using UnityEngine;
using System.Collections;

public class ItemRotator : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		/* inline create vector to spin different speeds based on angle */
		transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
	}
}
