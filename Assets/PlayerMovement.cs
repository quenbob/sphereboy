using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("up"))
			print ("up key was pressed");
		if (Input.GetKeyDown ("down"))
			print ("down key was pressed");
		if (Input.GetKeyDown ("left"))
			print ("left key was pressed");
		if (Input.GetKeyDown ("right"))
			print ("right key was pressed");
	}
}
