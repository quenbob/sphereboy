using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	// world units per second
	static float playerSpeed = 5.0f;

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

		transform.Translate (velocity * Time.deltaTime * playerSpeed);

		AudioSource sound = GameObject.Find("wacko").GetComponents<AudioSource>()[0];
		if (velocity.magnitude == 0.0f) {
			if (sound.isPlaying) sound.Stop();
		} else {
			if (!sound.isPlaying) sound.Play();
		}
	}
}
