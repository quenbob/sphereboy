using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3  velocity = new Vector2();

		if (Input.GetKey ("up"))
			velocity.z += 1;
		if (Input.GetKey ("down"))
			velocity.z -= 1;
		if (Input.GetKey ("left"))
			velocity.x -= 1;
		if (Input.GetKey ("right"))
			velocity.x += 1;

		print ("velocity = " + velocity);

		transform.Translate (velocity);
	}
}
